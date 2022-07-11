using ClownMeister.CityAi.Grid;
using UnityEngine;

namespace ClownMeister.CityAi.Manager
{
    public class GridManager : MonoBehaviour
    {
        private NodeGridRenderer gridRenderer;

        public NodeGridSettings gridSettings;

        private NodeGrid grid;

        private void Start()
        {
            this.gridRenderer = GetComponent<NodeGridRenderer>();
            this.grid = new NodeGrid(this.gridSettings);

            this.gridRenderer.Render(this.grid, this.gridSettings);
        }
    }
}