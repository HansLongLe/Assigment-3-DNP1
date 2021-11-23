using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Data.Models
{
    // ReSharper disable once ClassNeverInstantiated.Global
    
    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }
}