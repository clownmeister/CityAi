using ClownMeister.CityAi.Grid;
using UnityEngine;

namespace ClownMeister.CityAi.Manager
{
    [RequireComponent(typeof(NodeGridRenderer))]
    public class GridManager : MonoBehaviour
    {
        private NodeGridRenderer gridRenderer;

        public GameObject nodePrefab;
        public Vector2Int gridResolution;

        private NodeGrid grid;

        private void Start()
        {
            this.gridRenderer = GetComponent<NodeGridRenderer>();
            this.grid = new NodeGrid(this.gridResolution);

            this.gridRenderer.Render(this.grid);
        }
    }
}