namespace RobotObjectModel;

public class CommandGroup
{
    public List<Command> Commands = new();

    public void AddCommand(Command command)
    {
        Commands.Add(command);
    }

    public virtual void Execute()
    {
        
    }
}