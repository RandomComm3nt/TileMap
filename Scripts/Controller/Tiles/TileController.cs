using TileMap.Scripts.Controller.Objects;
using UnityEngine;

namespace TileMap.Scripts.Controller.Tiles
{
    [RequireComponent(typeof(TileRendererBase))]
    public class TileController : MonoBehaviour
    {
        private TileRendererBase tileRenderer;
        private MapController mapController;
        public Vector2Int Position { get; private set; }
        public ObjectController Object { get; private set; }

        public void Initialise(MapController mapController, int x, int y)
        {
            this.mapController = mapController;
            Position = new Vector2Int(x, y);
            transform.localPosition = new Vector2(x, y);

            tileRenderer = GetComponent<TileRendererBase>();
            RefreshTile();
        }

        public virtual void RefreshTile()
        {
            tileRenderer.RefreshTile(this);
        }
    }
}