using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace ConsoleAppTI.Entities;

public class OrderRowEntity
{

    [Key]
    public int RowId { get; set; }


    [Required]
    [ForeignKey(nameof(OrderEntity))]
    public int OrderId { get; set; }
    public virtual OrderEntity OrderEntity { get; set; } = null!;


    [Required]
    [ForeignKey(nameof(ProductEntity))]
    public int ProductId { get; set; }
    public virtual ProductEntity Product { get; set; } = null!;



    [Required]
    public int Quantity { get; set; }



    [Required]
    [Column(TypeName = "money")]
    public string PriceUnit { get; set; } = null!;



    [Required]
    [Column(TypeName = "money")]
    public string Price { get; set; } = null!;

    public virtual ICollection<OrderEntity> Orders { get; set; } = new HashSet<OrderEntity>();

    public virtual ICollection<ProductEntity> Products { get; set; } = new HashSet<ProductEntity>();

}
