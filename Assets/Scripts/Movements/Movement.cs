using UnityEngine;

namespace Movements
{
    public abstract class Movement : MonoBehaviour
    {
        public float speed;

        protected Vector3 direction;

        public abstract bool SetDirection(Vector3 direction);

        public abstract void Move();

        public abstract void StopMoving();
    }
}
