namespace Task5._1;

class Program
{
    static async Task Main(string[] args)
    {
        MultiplyBlock multiplyBlock = new MultiplyBlock();
        SubtractBlock subtractBlock = new SubtractBlock();
        DataflowLinker linker = new DataflowLinker();

        var sourceBlock = multiplyBlock.CreateMultiplyBlock();
        var targetBlock = subtractBlock.CreateSubtractBlock();

        linker.LinkBlocks(sourceBlock, targetBlock);

        sourceBlock.Complete();
        await targetBlock.Completion;
    }
}