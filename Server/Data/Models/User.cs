using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Server.Data.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [JsonPropertyName("username")]
        [Required]
        public string Username { get; set; }
        
        [JsonPropertyName("password")]
        [Required]
        public string Password { get; set; }
    }
}