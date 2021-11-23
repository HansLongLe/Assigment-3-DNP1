using System.Text.Json.Serialization;

namespace Client.Models {
public class Person {
    [JsonPropertyName("id")]
    public int Id { get; init; }
    
    [JsonPropertyName("firstName")]
    public string FirstName { get; init; }
    
    [JsonPropertyName("lastName")]
    public string LastName { get; init; }
    
    [JsonPropertyName("hairColor")]
    public string HairColor { get; init; }
    
    [JsonPropertyName("eyeColor")]
    public string EyeColor { get; init; }
    
    [JsonPropertyName("age")]
    public int Age { get; init; }
    
    [JsonPropertyName("weight")]
    public float Weight { get; init; }
    
    [JsonPropertyName("height")]
    public int Height { get; init; }
    
    [JsonPropertyName("sex")]
    public string Sex { get; init; }
}


}