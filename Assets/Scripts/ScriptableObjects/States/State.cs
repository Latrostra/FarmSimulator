using UnityEngine;

namespace ScriptableObjects.States
{
    public abstract class State : ScriptableObject
    {
        public abstract void _Init();

        public abstract void _Update();

        public abstract void _FixedUpdate();

        public abstract void _Finish();
    }


}
