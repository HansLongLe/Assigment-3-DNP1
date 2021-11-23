using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public class UserService : IUserService
    {
        private const string Uri = "https://localhost:5001";
        private readonly HttpClient _client;

        public UserService()
        {
            _client = new HttpClient();
        }
        public async Task<bool> GetResult(User user)
        {
            var userAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(
                userAsJson,
                Encoding.UTF8,
                "application/json");
            var responseMessage = await _client.PostAsync(Uri + "/Users", content);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var message = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<bool>(message);
            return result;
        }
        
    }
}