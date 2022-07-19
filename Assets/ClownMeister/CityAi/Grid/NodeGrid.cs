using UnityEngine;

namespace ClownMeister.CityAi.Grid
{
    public class NodeGrid
    {
        private readonly NodeGridSettings settings;
        public Node[,] Nodes { get; }

        public NodeGrid(NodeGridSettings settings)
        {
            this.settings = settings;
            this.Nodes = Generate(settings.resolution);
        }

        private Node[,] Generate(Vector2Int resolution)
        {
            Node[,] grid = new Node[resolution.x, resolution.y];

            for (int y = 0; y < resolution.y; y++) {
                for (int x = 0; x < resolution.x; x++) {
                    Vector3 position = GetPosition(x, y);
                    grid[x, y] = new Node(x, y, position);
                }
            }

            return grid;
        }

        private Vector3 GetPosition(int x, int y)
        {
            float nodeSize = this.settings.nodeSize + this.settings.gridNodeSpacing;

            return new Vector3(nodeSize * x, this.settings.gridStartPosition.y, nodeSize * y);
        }
    }
}