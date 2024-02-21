using System.Threading.Tasks.Dataflow;

namespace Task5._5;

class Program
{
    static async Task Main(string[] args)
    {
        var multiplyBlock = DataFlowBlocks.CreateMultiplyBlock();
        var subtractBlock = DataFlowBlocks.CreateSubtractBlock();

        DataFlowLinkManager.CreateLink(multiplyBlock, subtractBlock);

        multiplyBlock.Post(2);
        multiplyBlock.Post(3);

        multiplyBlock.Complete();
        await multiplyBlock.Completion.ContinueWith(_ =>
        {
            Console.WriteLine("Результаты обработки данных:");
            Console.WriteLine(subtractBlock.Receive());
            Console.WriteLine(subtractBlock.Receive());
        });
    }
}