using System.Threading.Tasks.Dataflow;

namespace Task_13._4;

public class DataFlowNetwork
{
    private readonly TransformBlock<int, int> _multiplyBlock;

    public DataFlowNetwork()
    {
        var options = TaskManager.GetExecutionOptions();
        _multiplyBlock = new TransformBlock<int, int>(item => item * 2);
        var displayBlock = new ActionBlock<int>(DisplayResult, options);
        _multiplyBlock.LinkTo(displayBlock);
    }

    public void PostData(int data)
    {
        _multiplyBlock.Post(data);
    }

    private void DisplayResult(int result)
    {
        Console.WriteLine(result);
    }
}