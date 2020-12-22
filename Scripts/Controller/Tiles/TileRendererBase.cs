using UnityEngine;

namespace TileMap.Scripts.Controller.Tiles
{
    [RequireComponent(typeof(SpriteRenderer))]
    public abstract class TileRendererBase : MonoBehaviour
    {
        protected SpriteRenderer SpriteRenderer { get; private set; }

        private void Awake()
        {
            SpriteRenderer = GetComponent<SpriteRenderer>(); 
        }

        public abstract void RefreshTile(TileController tileController);
    }
}
