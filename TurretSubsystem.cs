namespace RobotObjectModel;

public class TurretSubsystem
{
    public Servos ServosOne { get; set; } = new();

    public Shooter ShooterOne { get; set; } = new();
}