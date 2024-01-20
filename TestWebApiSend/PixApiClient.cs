using System.Text;

namespace TestWebApiSend
{
    public class PixApiClient
    {
        private readonly HttpClient _client;

        private const string Route = "Pix";

        public PixApiClient(HttpClient client)
        {
            _client = client;
        }

        public Task<HttpResponseMessage> Get() => _client.SendAsync(new HttpRequestMessage(HttpMethod.Get, Route));

        public Task<HttpResponseMessage> Post(string data)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, Route)
            {
                Content = new StringContent(data, Encoding.UTF8, "application/json"),
            };

            return _client.SendAsync(request);
        }
    }
}
