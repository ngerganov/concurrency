namespace Task_10._8;

class Program
{
    static async Task Main(string[] args)
    {
        var cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken = cancellationTokenSource.Token;

        var httpClient = new HttpClient();
        var url = "https://example.com";

        var httpClientHelper = new HttpClientHelper();
        var response = await httpClientHelper.GetWithTimeoutAsync(httpClient, url, cancellationToken);

        Console.WriteLine("HTTP Response Status Code: " + response.StatusCode);
    }
}