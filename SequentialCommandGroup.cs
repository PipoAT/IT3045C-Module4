namespace RobotObjectModel;

public class SequentialCommandGroup : CommandGroup
{
    public override void Execute() 
    {
        foreach(var command in Commands)
        {
            command.Execute();
        }
    }
}