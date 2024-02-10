using RobotObjectModel;

Robot robot = new()
{
    Name = "Charlie"
};

robot.Drive.DriveType = "Tank Drive";
robot.Drive.DriveForward();
int distance = robot.Drive.LeftMotor.Encoder.GetDistance();

SequentialCommandGroup driveInSquare = new();
ParallelCommandGroup dance = new();

MoveForwardCommand command1 = new();
driveInSquare.AddCommand(command1);

TurnLeftCommand command2 = new();
driveInSquare.AddCommand(command2);

MoveForwardCommand command3 = new();
driveInSquare.AddCommand(command3);

TurnLeftCommand command4 = new();
driveInSquare.AddCommand(command4);

MoveForwardCommand command5 = new();
driveInSquare.AddCommand(command5);

TurnLeftCommand command6 = new();
driveInSquare.AddCommand(command6);

MoveForwardCommand command7 = new();
driveInSquare.AddCommand(command7);

TurnLeftCommand command8 = new();
driveInSquare.AddCommand(command8);

driveInSquare.Execute();

