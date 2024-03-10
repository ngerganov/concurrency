using System.Threading.Tasks.Dataflow;

namespace Task_13._4;

public class TaskManager
{
    public static ExecutionDataflowBlockOptions GetExecutionOptions()
    {
        return new ExecutionDataflowBlockOptions
        {
            TaskScheduler = TaskScheduler.Current
        };
    }
}