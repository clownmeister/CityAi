using System;
using UnityEngine;

namespace ClownMeister.CityAi.Camera
{
    [Serializable]
    public abstract class AbstractCameraModule : MonoBehaviour, ICameraMovement
    {
        protected AbstractCameraModule()
        {
            Active = false;
        }

        public bool Active { get; set; }

        public CameraMovementSettings Settings { get; set; }
    }
}