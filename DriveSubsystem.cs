using System.Runtime.CompilerServices;

namespace RobotObjectModel;

public class DriveSubsystem
{
    public string DriveType { get; set; }

    public Motor LeftMotor { get; set; } = new();

    public Motor RightMotor { get; set; } = new();

    public void DriveForward()
    {
        LeftMotor.Forward();
        RightMotor.Forward();
    }

    public void DriveBackward()
    {
       LeftMotor.Backward();
       RightMotor.Backward();
    }

    public void TurnLeft()
    {
        LeftMotor.Forward();
        RightMotor.Backward();
    }

    public void TurnRight()
    {
        LeftMotor.Backward();
        RightMotor.Forward();
    }
}