using UnityEngine;

namespace ClownMeister.CityAi.Camera
{
    [CreateAssetMenu(menuName = "CityAi/Camera/MovementSettings", fileName = "newMovementSettings", order = 10)]
    public class CameraMovementSettings : ScriptableObject
    {
        public float moveSpeed;
        public float interpolateSpeed;
    }
}