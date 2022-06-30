using UnityEngine;

namespace ClownMeister.CityAi.Grid
{
    public class Node
    {
        public Node(Vector2Int coords)
        {
            Coords = coords;
        }

        public Node(int x, int y)
        {
            Coords = new Vector2Int(x, y);
        }

        public Vector2Int Coords { get; }
    }
}