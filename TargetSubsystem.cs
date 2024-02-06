namespace RobotObjectModel;

public class TargetSubsystem
{
    public Sonar SonarOne { get; set; } = new();

    public Camera CameraOne { get; set; } = new();
}