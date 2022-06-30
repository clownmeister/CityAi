using ClownMeister.CityAi.Grid;
using UnityEngine;

namespace ClownMeister.CityAi.Manager
{
    [RequireComponent(typeof(NodeRenderer))]
    public class GridManager : MonoBehaviour
    {
        public Vector2Int gridResolution;
        public Vector3 gridRealPosition;
        public float gridNodeSize;
        public float gridNodeSpacing;

        private NodeGrid grid;
        private NodeRenderer renderer;

        private void Start()
        {
            this.renderer = GetComponent<NodeRenderer>();
            this.grid = new NodeGrid(this.gridResolution);
        }

        private void Render()
        {
            this.renderer.RenderGrid(this.gridRealPosition, this.grid, this.gridNodeSize, this.gridNodeSpacing);
        }
    }
}