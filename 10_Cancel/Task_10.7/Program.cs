using System.Threading.Tasks.Dataflow;

namespace Task_10._7;

class Program
{
    static async Task Main(string[] args)
    {
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;

        var cancellationTokenNetwork = new CancellationTokenNetwork();
        var dataflowBlock = cancellationTokenNetwork.CreateMyCustomBlock(cancellationToken);

        var inputData = 10;
        Console.WriteLine($"Input data: {inputData}");

        dataflowBlock.Post(inputData);

        var result = await dataflowBlock.ReceiveAsync(cancellationToken);

        Console.WriteLine($"Result: {result}");
    }
}