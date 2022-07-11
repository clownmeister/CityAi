using UnityEngine;

namespace ClownMeister.CityAi.Grid
{
    public class NodeGrid
    {
        private Vector2 resolution;
        public Node[,] Nodes { get; }

        public NodeGrid(Vector2Int resolution)
        {
            this.resolution = resolution;
            this.Nodes = Generate(resolution);
        }

        private Node[,] Generate(Vector2Int resolution)
        {
            Node[,] grid = new Node[resolution.x, resolution.y];

            for (int y = 0; y < resolution.y; y++) {
                for (int x = 0; x < resolution.x; x++) {
                    grid[x, y] = new Node(x, y);
                }
            }

            return grid;
        }
    }
}