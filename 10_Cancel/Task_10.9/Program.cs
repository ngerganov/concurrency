using System.Net.NetworkInformation;

namespace Task_10._9;

class Program
{
    static async Task Main(string[] args)
    {
        var cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken = cancellationTokenSource.Token;

        var pingService = new PingService();

        try
        {
            Task<PingReply> pingTask = pingService.PingAsync("example.com", cancellationToken);

            await Task.Delay(2000);

            cancellationTokenSource.Cancel();

            PingReply reply = await pingTask;
            Console.WriteLine($"Статус ответа: {reply.Status}");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Операция была отменена");
        }
    }
}