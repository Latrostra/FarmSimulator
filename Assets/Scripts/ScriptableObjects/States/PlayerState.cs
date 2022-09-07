using ScriptableObjectArchitecture;
using UnityEngine;

namespace ScriptableObjects.States
{
    [CreateAssetMenu(fileName = "PlayerState", menuName = "PlayerState/PlayerState", order = 52)]
    public abstract class PlayerState : State
    {
        [SerializeField] protected GameObjectVariable playerGO;

        protected Rigidbody2D rigidbody2D;
        protected Transform transform;
        protected Animator animator;
        protected Collider2D collider2D;

        private void Initialization()
        {
            Debug.Log(playerGO.Value.name);
            rigidbody2D = playerGO.Value.GetComponent<Rigidbody2D>();
            transform = playerGO.Value.transform;
            animator = playerGO.Value.GetComponent<Animator>();
            collider2D = playerGO.Value.GetComponent<Collider2D>();
        }

        public override void _Init()
        {
            Initialization();

            playerGO.Value.SetActive(true);
        }

        public override void _Finish()
        {
            playerGO.Value.SetActive(false);
        }
    }
}
