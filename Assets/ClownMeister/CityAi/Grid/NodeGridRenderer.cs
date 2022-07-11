using UnityEngine;

namespace ClownMeister.CityAi.Grid
{
    public class NodeGridRenderer : MonoBehaviour
    {
        public const string GridParentLabel = "GridNodes";

        public void Render(NodeGrid grid, NodeGridSettings settings)
        {
            Transform parent = GetParent();
            foreach (Node node in grid.Nodes) {
                GameObject instantiated = Instantiate(settings.nodePrefab, node.Position, Quaternion.identity);
                instantiated.transform.parent = parent;
            }
        }

        private Transform GetParent(bool create = true)
        {
            GameObject parent = GameObject.Find(GridParentLabel);
            if (null == parent && create == true) {
                parent = new GameObject(GridParentLabel);
            }
            else {
                return null;
            }

            return parent.transform;
        }
    }
}