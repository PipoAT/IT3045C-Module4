namespace RobotObjectModel;

public class Robot
{
    public string Name { get; set; }

    public DriveSubsystem Drive { get; set; } = new();

    public TurretSubsystem Turret { get; set; } = new();

    public TargetSubsystem Targeting { get; set; } = new();
}