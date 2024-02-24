using System.Threading.Tasks.Dataflow;

namespace Task_7._4;

public class MyCustomBlock
{
    private readonly TransformBlock<int, int> _transformBlock;

    public MyCustomBlock()
    {
        _transformBlock = new TransformBlock<int, int>(item => item + 1);
    }

    public ISourceBlock<int> SourceBlock => _transformBlock;
    public ITargetBlock<int> TargetBlock => _transformBlock;

    public void Complete() => _transformBlock.Complete();
    public Task Completion => _transformBlock.Completion;

    public void Fault(Exception exception) => ((IDataflowBlock)_transformBlock).Fault(exception);
}