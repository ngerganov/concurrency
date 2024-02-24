using System.Net;

namespace Task_8._2;

public static class WebRequestExtensions
{
    public static Task<WebResponse> GetResponseAsync(this WebRequest client)
    {
        return Task<WebResponse>.Factory.FromAsync(client.BeginGetResponse, client.EndGetResponse, null);
    }
}