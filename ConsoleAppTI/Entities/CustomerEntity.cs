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

    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string CustomerEmail { get; set; } = null!;


    [Required]
    [ForeignKey(nameof(OrderEntity))]

    public int OrderId { get; set; }

    public virtual OrderEntity Order { get; set; } = null!;
}
