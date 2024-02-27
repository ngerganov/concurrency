using System.Net.NetworkInformation;

namespace Task_10._9;

public class PingService
{
    public async Task<PingReply> PingAsync(string hostNameOrAddress, CancellationToken cancellationToken)
    {
        using var ping = new Ping();
        Task<PingReply> task = ping.SendPingAsync(hostNameOrAddress);
        await using CancellationTokenRegistration _ = cancellationToken.Register(() => ping.SendAsyncCancel());
        return await task;
    }
}