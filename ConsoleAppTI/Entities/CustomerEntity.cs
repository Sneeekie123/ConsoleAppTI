using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppTI.Entities;

public class CustomerEntity
{
    [Key]
    public int CustomerId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string CustomerName { get; set; } = null!;


}
