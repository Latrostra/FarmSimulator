using System;
using ScriptableObjectArchitecture;
using UnityEngine;
using Action = Models.Action;

namespace ScriptableObjects.States
{
    [CreateAssetMenu(fileName = "WorkingState", menuName = "PlayerState/WorkingState", order = 52)]
    public class WorkingState : PlayerState
    {
        [SerializeField] private float speed = 2f;
        [SerializeField] private ToolVariable activeTool;
        [SerializeField] private TypeGameEvent changeStateByType;

        private float startingTime;

        public override void _Init()
        {
            base._Init();
            startingTime = Time.time;
        }

        public override void _Update()
        {
            if (CanWorking())
            {
                Work();
            }
            else
            {
                ChangeState();
            }
        }

        public override void _FixedUpdate()
        {
        }

        private void Work()
        {
            if (CanCreate())
            {
                activeTool.Value.Use(transform.position);
                startingTime = Time.time;
            }

            Animate();
        }

        private bool IsWorking() => Action.GetPlayerActions().Work.IsPressed();

        private bool CanWorking() => IsWorking() && activeTool.Value.CanUse(transform.position);

        private bool CanCreate() => Time.time - startingTime >= activeTool.Value.GetCreationTime();

        private void ChangeState()
        {
            changeStateByType.Raise(typeof(MovingState));
        }

        private void Animate()
        {
            animator.Play(activeTool.Value.AnimationType.Name);
        }
    }
}
