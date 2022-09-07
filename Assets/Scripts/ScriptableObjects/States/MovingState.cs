using System;
using Managers;
using ScriptableObjectArchitecture;
using UnityEngine;
using Action = Models.Action;

namespace ScriptableObjects.States
{
    [CreateAssetMenu(fileName = "MovingState", menuName = "PlayerState/MovingState", order = 52)]
    public class MovingState : PlayerState
    {
        [SerializeField] private float speed = 2f;
        [SerializeField] private RaycastCameraVariable raycastCameraVariable;
        [SerializeField] private TypeGameEvent changeStateByType;

        private Vector2 moveInput;

        public override void _Update()
        {
            moveInput = GetMoveInput();

            Animate();
            Do();
        }

        private void Do()
        {
            Work();
            Enter();
        }

        public override void _FixedUpdate()
        {
            Move();
        }

        private void Move() => rigidbody2D.MovePosition((Vector2)transform.position + moveInput * (speed * Time.fixedDeltaTime));

        private Vector2 GetMoveInput() => Action.GetPlayerActions().Move.ReadValue<Vector2>();

        private void Animate()
        {
            animator.SetFloat("Horizontal", moveInput.x);
            animator.SetFloat("Vertical", moveInput.y);
            animator.SetFloat("Speed", moveInput == Vector2.zero ? 0 : 1);
        }

        private void Work()
        {
            if (!Action.GetPlayerActions().Work.triggered)
                return;
        
            changeStateByType.Raise(typeof(WorkingState));
        }

        private void Enter()
        {
            if (!Action.GetPlayerActions().EnterExit.triggered)
                return;

            var hit = raycastCameraVariable.Value.GetRaycastHit(transform.position, LayerMask.GetMask("Interactable"));
            var interactable = raycastCameraVariable.Value.GetInteractable(hit);

            Interact(interactable);
        }

        private void Interact(Interactable interactable)
        {
            if (!interactable)
                return;

            interactable.OnInteract();
        }
    }
}
