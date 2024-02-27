namespace Task_10._8;

public class HttpClientHelper
{
    public async Task<HttpResponseMessage> GetWithTimeoutAsync(HttpClient client, string url, CancellationToken cancellationToken)
    {
        using CancellationTokenSource cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cts.CancelAfter(TimeSpan.FromSeconds(2));
        CancellationToken combinedToken = cts.Token;
        return await client.GetAsync(url, combinedToken);
    }
}