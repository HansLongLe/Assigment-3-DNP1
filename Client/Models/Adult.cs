using System.Text.Json.Serialization;

namespace Client.Models {
public class Adult : Person {
    [JsonPropertyName("jobTitle")]
    public Job JobTitle { get; init; }
}
}