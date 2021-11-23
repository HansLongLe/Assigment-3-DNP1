using System.Text.Json.Serialization;

namespace Client.Models
{
    public class Job
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }
        
        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; init; }
        
        [JsonPropertyName("salary")]
        public int Salary { get; init; }
    }
}