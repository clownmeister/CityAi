using UnityEngine;

namespace ClownMeister.CityAi.Grid
{
    [CreateAssetMenu(menuName = "CityAi/Grid/Settings", fileName = "newGridSettings", order = 10)]
    public class NodeGridSettings : ScriptableObject
    {
        public GameObject nodePrefab;
        public Vector2Int resolution;
        public Vector3 gridStartPosition;
        public float nodeSize;
        public float gridNodeSpacing;
    }
}