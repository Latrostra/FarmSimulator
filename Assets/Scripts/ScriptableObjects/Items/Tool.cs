using ScriptableObjects.Tiles;
using UnityEngine;

namespace ScriptableObjects.Items
{
    [CreateAssetMenu(fileName = "New Tool", menuName = "Item/Tool", order = 55)]
    [SerializeField]
    public class Tool : Item
    {
        [field: SerializeField] public string Name { get; private set; }

        [field: SerializeField] public int Level { get; private set; }

        [field: SerializeField] public Sprite Sprite { get; private set; }

        [field: SerializeField] public float Range { get; private set; }

        [field: SerializeField] public float Durability { get; private set; }

        [field: SerializeField] public AnimationType AnimationType { get; private set; }

        [field: SerializeField] public Tile Tile { get; private set; }

        public void Use(Vector2 position)
        {
            Tile.Create(position);
        }

        public float GetCreationTime()
        {
            return Tile.GetCreationTime();
        }

        public virtual bool CanUse(Vector2 position)
        {
            return Tile.CanCreate(position);
        }
    }
}
