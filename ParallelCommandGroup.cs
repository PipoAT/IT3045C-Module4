namespace RobotObjectModel;

public class ParallelCommandGroup: CommandGroup
{
    public override void Execute()
    {
        Parallel.ForEach(Commands, cmd =>
        {
            cmd.Execute();
        });
    }
}