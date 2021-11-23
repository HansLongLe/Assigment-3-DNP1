using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Data.Models {
public class Adult : Person {
    [ForeignKey("Job")]
    public Job JobTitle { get; set; }
}
}