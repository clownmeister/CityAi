using UnityEngine;

namespace ClownMeister.CityAi.Grid
{
    public class NodeGridRenderer : MonoBehaviour
    {
        public void Render(NodeGrid grid)
        {
            foreach (Node node in grid.Nodes) {
                Debug.Log(node.Coords);
            }
        }
    }
}