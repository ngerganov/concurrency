using System.Threading.Tasks.Dataflow;

namespace Task_12._5;

class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            var dataflowMultiplier = new DataflowMultiplier();
            var dataflowBlock = dataflowMultiplier.MultiplyBy2();

            dataflowBlock.LinkTo(new ActionBlock<int>(data => Console.WriteLine($"DataflowBlock output: {data}")));

            for (int i = 1; i <= 10; i++)
            {
                dataflowBlock.Post(i);
            }

            dataflowBlock.Complete();
            await dataflowBlock.Completion;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        var parallelMultiplier = new ParallelMultiplier();
        var multipliedValues = parallelMultiplier.MultiplyBy2(Enumerable.Range(1, 10));

        Console.WriteLine("Multiplied values using ParallelMultiplier:");
        foreach (var value in multipliedValues)
        {
            Console.WriteLine(value);
        }

        var matrixProcessor = new MatrixProcessor();
        var matrices = new List<Matrix>();
        matrixProcessor.RotateMatrices(matrices, 90);

        var urlDownloader = new UrlDownloader();
        var client = new HttpClient();
        var urls = new List<string>();
        var downloadedData = await urlDownloader.DownloadUrlsAsync(client, urls);

        Console.WriteLine("Downloaded data:");
        foreach (var data in downloadedData)
        {
            Console.WriteLine(data);
        }
    }
}