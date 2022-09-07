using Models;
using ScriptableObjectArchitecture;
using UnityEngine;

namespace ScriptableObjects.States
{
    [CreateAssetMenu(fileName = "DrivingState", menuName = "VehicleState/DrivingState", order = 51)]
    public class DrivingState : VehicleState
    {
        [SerializeField] private float speed = 1f;
        [SerializeField] private float breakSpeed = 3f;
        [SerializeField] private float rotateSpeed = 20f;
        [SerializeField] private float maxSpeed = 3f;
        [SerializeField] private TypeGameEvent changeStateByType;
        [SerializeField] private RaycastCameraVariable raycastCameraVariable;
        private Vector2 moveInput;
        private float acceleration = 0f;
        private Vector2 lastDir;
        public override void _Init()
        {
            base._Init();
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
            acceleration = 0f;
            animator.SetBool("IsRunning", true);
        }

        public override void _Update()
        {
            moveInput = GetMoveInput();
            Exit();
        }

        public override void _FixedUpdate()
        {
            var hit = raycastCameraVariable.Value.GetRaycastHit(transform.position, LayerMask.GetMask("Bloking"));
            if (hit.collider != null) {
                return;
            }
            if (moveInput.y > 0) {
                if (acceleration < 0) {
                    acceleration += breakSpeed * 2 * Time.fixedDeltaTime;
                    acceleration = Mathf.Clamp(acceleration, -maxSpeed, maxSpeed);
                    Break();
                }
                acceleration += speed * Time.fixedDeltaTime;
                Move();
                lastDir = -transform.up;
                animator.SetBool("IsDrive", true);
                if (moveInput.x != 0 && acceleration > 2f) {
                    Steering(-1);
                }
                return;
            }
            if (moveInput.y < 0) {
                if (acceleration > 0) {
                    acceleration -= breakSpeed * 2 * Time.fixedDeltaTime;
                    acceleration = Mathf.Clamp(acceleration, -maxSpeed, maxSpeed);
                    Break();
                }
                acceleration -= speed * Time.fixedDeltaTime;
                Move();
                lastDir = transform.up;
                animator.SetBool("IsDrive", true);
                if (moveInput.x != 0  && acceleration < 2f) {
                    Steering(1);
                }
                return;
            }
            if (acceleration > 0) {
                acceleration -= breakSpeed * Time.fixedDeltaTime;
                acceleration = Mathf.Clamp(acceleration, 0, maxSpeed);
                Break();
            }
            if (acceleration < 0) {
                acceleration += breakSpeed * Time.fixedDeltaTime;
                acceleration = Mathf.Clamp(acceleration, -maxSpeed, 0);
                Break();
            }
            animator.SetBool("IsDrive", false);
        }

        private void Move() {
            acceleration = Mathf.Clamp(acceleration, -maxSpeed, maxSpeed);
            rigidbody2D.MovePosition((Vector2)transform.position + (Vector2)(-transform.up) * acceleration * Time.fixedDeltaTime);
        }

        private void Break() {
            rigidbody2D.MovePosition((Vector2)transform.position + (Vector2)(-transform.up) * acceleration * Time.fixedDeltaTime);
        }

        private void Steering(float factor) {
            rigidbody2D.gameObject.transform.Rotate(new Vector3(0, 0, moveInput.x) * rotateSpeed * factor * Time.fixedDeltaTime, Space.World);
        }

        private Vector2 GetMoveInput() => Action.GetPlayerActions().Move.ReadValue<Vector2>();

        private void Do() {
            if (!Action.GetPlayerActions().Work.triggered)
                return;

            
        }

        private void Work() {
            if (!Action.GetPlayerActions().Work.triggered)
                return;

            // if (CanCreate())
            // {
            //     activeTool.Value.Use(transform.position);
            //     startingTime = Time.time;
            // }
        }

        private void Exit()
        {
            if (!Action.GetPlayerActions().EnterExit.triggered)
                return;

            GetOff();
            animator.SetBool("IsRunning", false);
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
            acceleration = 0f;
            changeStateByType.Raise(typeof(MovingState));
        }

        private void GetOff()
        {
            player.Value.transform.position = transform.Find("Exit").position;
        }
    }
}
