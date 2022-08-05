using Helpers;
using Types;
using UnityEngine;
using AnimationType = ScriptableObjects.AnimationType;

namespace Managers
{
    public class AnimationManager : Singleton<AnimationManager>
    {
        // public Animator cinemachineAnimator;

        private OldAnimationType currentType;
        // public void SwitchState(State state)
        // {
        //     switch (state)
        //     {
        //         case IdleState idleState:
        //             cinemachineAnimator.Play("PlayerCamera");
        //             break;
        //         case InVehicleState inVehicleState:
        //             cinemachineAnimator.Play("VehicleCamera");
        //             break;
        //     }
        // }
        //
        // public void AnimateMove(Animator animator, Vector3 direction)
        // {
        //     animator.SetFloat("Horizontal", direction.x);
        //     animator.SetFloat("Vertical", direction.y);
        //     animator.SetFloat("Speed", direction.sqrMagnitude);
        // }

        public void AnimateMove(Animator animator, Vector3 direction, float speed)
        {
            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Vertical", direction.y);
            animator.SetFloat("Speed", speed);
        }

        public void AnimateStart(Animator animator)
        {
            animator.SetBool("IsRunning", true);
        }
        public void AnimateStop(Animator animator)
        {
            animator.SetBool("IsRunning", false);
        }

        public void Play(Animator animator, OldAnimationType type)
        {
            if (currentType == type) return;

            animator.Play(type.ToString());
            currentType = type;
        }
    }
}
