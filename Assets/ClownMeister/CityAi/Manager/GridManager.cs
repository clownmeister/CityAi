using ClownMeister.CityAi.Grid;
using UnityEngine;

namespace ClownMeister.CityAi.Manager
{
    public class GridManager : MonoBehaviour
    {
        public Vector2Int gridResolution;

        private NodeGrid grid;

        private void Start()
        {
            this.grid = new NodeGrid(this.gridResolution);
        }
    }
}