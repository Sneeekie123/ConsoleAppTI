using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppTI.Entities;

public class OrderEntity
{

    [Key]
    public int OrderId { get; set; }
    [Required]

    [ForeignKey(nameof(CustomerEntity))]
    public int CustomerId { get; set; }

    public virtual CustomerEntity Customer { get; set; } = null!;

    [Required]
    [Column(TypeName = "datetime2")]
    public DateTime OrderDate { get; set; }

    public virtual ICollection<OrderEntity> Orders { get; set; } = new HashSet<OrderEntity>();

}
