using System.Net;

namespace Task_8._2;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://example.com";
        WebRequest request = WebRequest.Create(url);

        try
        {
            WebResponse response = await WebRequestExtensions.GetResponseAsync(request);
            Console.WriteLine("Ответ получен.");

            await using Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseContent = await reader.ReadToEndAsync();
            Console.WriteLine("Содержание ответа:");
            Console.WriteLine(responseContent);
        }
        catch (WebException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}