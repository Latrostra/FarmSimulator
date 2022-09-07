using ScriptableObjects.Tiles;
using UnityEngine;
using Managers;

namespace ScriptableObjects.Items
{
    [CreateAssetMenu(fileName = "New Seed", menuName = "Item/Seed", order = 56)]
    public class Seed : Tool
    {
        [field: SerializeField] public int dayFrom;
        [field: SerializeField] public int dayTo;
        [field: SerializeField] public int monthFrom;
        [field: SerializeField] public int monthTo;

        public override bool CanUse(Vector2 position)
        {
            if ((TimeLapse.Instance.dateTime.Value.Day >= dayFrom && TimeLapse.Instance.dateTime.Value.Day <= dayTo) && (TimeLapse.Instance.dateTime.Value.Months >= monthFrom && TimeLapse.Instance.dateTime.Value.Months <= monthTo)) {
                return Tile.CanCreate(position);
            }
            return false;
        }
    }
}
