using System.Collections.Generic;

namespace TileMap.Scripts.Controller.MapControllerStates
{
    /// <summary>
    /// MapController uses an FSM to determine actions a player can take when interacting with the map
    /// This is the base class for each state the MapController can be in
    /// </summary>
    public abstract class MapControllerState
    {
        public virtual void Enter(MapController mapController)
        {

        }

        public virtual void Exit()
        {

        }

        public void MouseOverTile(TileController tileController)
        {

        }

        public void MouseOutTile(TileController tileController)
        {

        }

        public void MouseDownTile(TileController tileController)
        {

        }

        public void MouseUpTile(TileController tileController)
        {

        }

        public void ClickTile(TileController tileController)
        {
            SelectSingleTile(tileController);
        }

        protected virtual void SelectSingleTile(TileController tileController)
        {

        }

        protected virtual void SelectMultipleTiles(List<TileController> tileController)
        {

        }

        protected virtual bool IsSelectionValid()
        {
            return true;
        }
    }
}
