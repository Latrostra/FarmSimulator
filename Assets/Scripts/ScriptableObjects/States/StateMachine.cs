using System;
using System.Linq;
using ScriptableObjectArchitecture;
using UnityEngine;

namespace ScriptableObjects.States
{
    public class StateMachine : MonoBehaviour
    {
        [SerializeField] private State startingState;
        [SerializeField] private StateVariable currentState;
        [SerializeField] private StateVariable previousState;
        [SerializeField] private StateCollection availableStates;
        [SerializeField] private StateGameEvent changeState;
        [SerializeField] private BoolVariable isGameActive;
        [SerializeField] private TypeGameEvent changeStateByType;

        private void OnEnable()
        {
            changeState.AddListener(ChangeState);
            changeStateByType.AddListener(ChangeState);
        }

        private void OnDisable()
        {
            changeState.RemoveListener(ChangeState);
            changeStateByType.RemoveListener(ChangeState);
        }

        private void Start()
        {
            currentState.Value = startingState;
            currentState.Value._Init();
            isGameActive.Value = true;
        }

        private void Update()
        {
            if (isGameActive.Value)
                currentState.Value._Update();
        }

        private void FixedUpdate()
        {
            if (isGameActive.Value)
                currentState.Value._FixedUpdate();
        }

        public void ChangeState(State newState)
        {
            if (newState == currentState.Value)
                return;

            if (!availableStates.Contains(newState))
                return;

            SetState(newState);
        }

        public void BackToPreviousState()
        {
            if (currentState.Value == previousState.Value)
                return;

            SetState(previousState.Value);
        }

        public void ChangeState(Type newStateType)
        {
            var newState = availableStates.First(x => x.GetType() == newStateType);

            SetState(newState);
        }

        private void SetState(State newState)
        {
            Debug.Log($"Change state: ({currentState.Value.GetType()}) => ({newState.GetType()})");
            
            currentState.Value._Finish();
            currentState.Value = newState;
            currentState.Value._Init();
        }

        private bool IsSameFamily(State newState) => currentState.Value.GetType().BaseType?.Name == newState.GetType().BaseType?.Name;
    }
}
