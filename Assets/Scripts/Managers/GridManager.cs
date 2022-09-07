using Helpers;
using UnityEngine;
using UnityEngine.Tilemaps;
using Tile = ScriptableObjects.Tiles.Tile;

namespace Managers
{
    public class GridManager : Singleton<GridManager>
    {
        public Grid grid;
        public Tilemap tilemap;
        public GameObject[,] gridGO;

        public void Start() {
            gridGO = new GameObject[1000,1000];
        }
        public Vector3 GetCellCenterPosition(Vector3 destinationDirection)
        {
            return grid.GetCellCenterWorld(GetWorldPosition(destinationDirection));
        }

        public Vector3Int GetWorldPosition(Vector3 position)
        {
            return grid.WorldToCell(position);
        }

        public Tilemap GetTilemap()
        {
            return tilemap;
        }
        
        public bool CanCreateNew(Vector3 position, Tile tile)
        {
            return (tile.PreviousTile == null && tile.RuleTile != tilemap.GetTile(GetWorldPosition(position))) || tile.PreviousTile == tilemap.GetTile(GetWorldPosition(position));
        }
    }
}
