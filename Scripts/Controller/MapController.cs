using System.Collections.Generic;
using TileMap.Scripts.Controller.MapControllerStates;
using UnityEngine;

namespace TileMap.Scripts.Controller
{
    public class MapController : TileController
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
    }
}
