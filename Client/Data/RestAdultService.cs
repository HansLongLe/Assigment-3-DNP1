using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public class RestAdultService : IAdultsService
    {
        private const string Uri = "https://localhost:5001";
        private readonly HttpClient _client;

        public RestAdultService()
        {
            _client = new HttpClient();
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            var responseMessage = await _client.GetAsync(Uri + "/Adults");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }

            var message = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }
        public async Task AddAdultAsync(Adult adult)
        {
            var adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(
                adultAsJson,
                Encoding.UTF8,
                "application/json");
            var responseMessage = await _client.PostAsync(Uri + "/Adults", content);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }
}
}