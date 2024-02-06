using RobotObjectModel;

Robot robot = new()
{
    Name = "Charlie"
};

robot.Drive.DriveType = "Tank Drive";
robot.Drive.DriveForward();
int distance = robot.Drive.LeftMotor.Encoder.GetDistance();


