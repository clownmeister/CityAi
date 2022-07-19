using UnityEngine;

namespace ClownMeister.CityAi.Grid
{
    public class Node
    {
        public Node(Vector2Int gridCoords, Vector3 position)
        {
            GridCoords = gridCoords;
            Position = position;
        }

        public Node(int x, int y, Vector3 position)
        {
            GridCoords = new Vector2Int(x, y);
            Position = position;
        }

        public Vector2Int GridCoords { get; }
        public Vector3 Position { get; }
    }
}