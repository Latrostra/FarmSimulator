using Managers;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace ScriptableObjects.Tiles
{
    [CreateAssetMenu(fileName = "NewTile", menuName = "TilesNaszeFirmowe", order = 53)]
    public class Tile : TileBase
    {
        [field: SerializeField] public RuleTile RuleTile { get; private set;}
        [field: SerializeField] public AdvancedRuleTile PreviousTile { get; private set;}
        public Sprite sprite;
        [SerializeField] private GameObject prefab;
        [SerializeField] private float creationTime;

        public void Create(Vector2 position)
        {
            var tilemap = GridManager.Instance.GetTilemap();
            
            if (prefab != null) {
                var obj = Instantiate(prefab, GridManager.Instance.GetWorldPosition(position), Quaternion.identity, tilemap.transform);
            }
            if (RuleTile != null) {
                tilemap.SetTile(GridManager.Instance.GetWorldPosition(position), RuleTile);
            }
        }

        public float GetCreationTime() => creationTime;

        public bool CanCreate(Vector2 position) => GridManager.Instance.CanCreateNew(position, this);
    }
}
