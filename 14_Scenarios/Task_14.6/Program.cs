using System.Threading.Tasks.Dataflow;

namespace Task_14._6;

class Program
{
    static async Task Main(string[] args)
    {
        var subtractBlock = RailwayTransform.CreateTransformBlock<int, int>(value => value - 2);
        var divideBlock = RailwayTransform.CreateTransformBlock<int, int>(value => 60 / value);
        var multiplyBlock = RailwayTransform.CreateTransformBlock<int, int>(value => value * 2);
        var options = new DataflowLinkOptions { PropagateCompletion = true };
        subtractBlock.LinkTo(divideBlock, options);
        divideBlock.LinkTo(multiplyBlock, options);

        subtractBlock.Post(Try.FromValue(5));
        subtractBlock.Post(Try.FromValue(2));
        subtractBlock.Post(Try.FromValue(4));
        subtractBlock.Complete();

        while (await multiplyBlock.OutputAvailableAsync())
        {
            Try<int> item = await multiplyBlock.ReceiveAsync();
            if (item.IsValue)
                Console.WriteLine("Результат: " + item.Value);
            else
                Console.WriteLine("Ошибка: " + item.Exception.Message);
        }
    }
}