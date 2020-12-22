using System.Collections.Generic;
using System.Linq;
using TileMap.Scripts.Controller.MapControllerStates;
using TileMap.Scripts.Controller.Tiles;
using UnityEngine;

namespace TileMap.Scripts.Controller
{
    public class MapController : MonoBehaviour
    {
        [SerializeField] private TileController tilePrefab = null;

        private List<List<TileController>> tiles;
        private MapControllerState mapControllerState;

        public MapControllerState MapControllerState
        {
            get => mapControllerState; set
            {
                mapControllerState?.Exit();
                mapControllerState = value;
                mapControllerState.Enter(this);
            }
        }

        public void CreateMap(int width, int height)
        {
            tiles = Enumerable
                .Range(0, width)
                .Select(i => Enumerable
                    .Range(0, height)
                    .Select(j => CreateTile(i, j))
                    .ToList())
                .ToList();
        }

        private TileController CreateTile(int x, int y)
        {
            var t = Instantiate(tilePrefab, transform);
            t.Initialise(this, x, y);
            return t;
        }
    }
}
