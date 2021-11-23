using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Data.Models {
public class Person {
    [Key]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    [Required]
    public int Age { get; set; }
    [Required]
    public float Weight { get; set; }
    [Required]
    public int Height { get; set; }
    [Required]
    public string Sex { get; set; }
}


}