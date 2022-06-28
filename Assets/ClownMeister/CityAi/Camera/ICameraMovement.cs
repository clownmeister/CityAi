namespace ClownMeister.CityAi.Camera
{
    public interface ICameraMovement
    {
        public bool Active { get; set; }
        public CameraMovementSettings Settings { get; set; }
    }
}