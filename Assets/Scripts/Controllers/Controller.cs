using System;
using Movements;
using UnityEngine;

namespace Controllers
{
    public class Controller : MonoBehaviour, IController
    {
        public Animator animator;
        public Movement movement;

        protected bool canMove;

        public virtual void Move(Vector3 position)
        {
            throw new NotImplementedException();
        }

        public virtual void Work(Vector3 position)
        {
            throw new NotImplementedException();
        }

        public void SetActive(bool active)
        {
            gameObject.SetActive(active);
        }
    }
}
