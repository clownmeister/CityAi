using UnityEngine;

namespace ClownMeister.CityAi.Camera
{
    public class TopDownCameraModule : AbstractCameraModule
    {
        public Vector3 targetPosition, oldTargetPosition, startingTransitionPosition;
        private float interpolater;

        private void Start()
        {
            Vector3 position = transform.position;

            this.startingTransitionPosition = position;
            this.oldTargetPosition = position;
            this.targetPosition = position;
        }

        private void Update()
        {
            if (!Active) return;

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Move(new Vector3(x, 0, z));
        }

        private void Move(Vector3 direction)
        {
            if (Mathf.Abs(direction.x + direction.z) > 1)
            {
                direction = direction.normalized;
            }

            this.targetPosition += direction * (Settings.moveSpeed * Time.deltaTime);

            //If target moved 
            if (this.targetPosition != this.oldTargetPosition)
            {
                //Reset transition
                this.oldTargetPosition = this.targetPosition;
                this.startingTransitionPosition = transform.position;
            }

            this.interpolater = Vector3.SqrMagnitude(transform.position - this.targetPosition) * Settings.interpolateSpeed;

            //finished transition
            if (transform.position == this.targetPosition)
            {
                return;
            }

            //Step transition
            transform.position = Vector3.Lerp(this.startingTransitionPosition, this.targetPosition, this.interpolater);
        }
    }
}