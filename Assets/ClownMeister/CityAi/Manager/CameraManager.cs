using ClownMeister.CityAi.Camera;
using UnityEngine;

namespace ClownMeister.CityAi.Manager
{
    public class CameraManager : MonoBehaviour
    {
        public CameraMovementSettings cameraSettings;
        public AbstractCameraModule[] cameraMovementModules;
        private int moduleIndex;

        public CameraManager(int moduleIndex)
        {
            this.moduleIndex = 0;
        }

        private void Start()
        {
            foreach (AbstractCameraModule cameraModule in this.cameraMovementModules)
            {
                cameraModule.Settings = this.cameraSettings;
            }

            ActivateSelectedModule();
        }

        private void Update()
        {
            if (Input.GetAxis("CameraView") == 0) return;

            ActivateSelectedModule(false);
            IncreaseIndex();
            ActivateSelectedModule();
        }

        private void ActivateSelectedModule(bool activate = true)
        {
            this.cameraMovementModules[this.moduleIndex].Active = activate;
        }


        private void IncreaseIndex(bool increment = true)
        {
            if (increment)
            {
                this.moduleIndex++;
                if (this.moduleIndex >= this.cameraMovementModules.Length)
                {
                    this.moduleIndex = 0;
                }

                return;
            }

            this.moduleIndex--;
            if (this.moduleIndex < 0)
            {
                this.moduleIndex = this.cameraMovementModules.Length - 1;
            }
        }
    }
}