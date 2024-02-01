using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ConsoleAppTI.Entities;

public class OrderRowEntity
{

    [Key]
    public int RowId { get; set; }


    [Required]
    [ForeignKey(nameof(OrderEntity))]

    public int OrderId { get; set; }

    public virtual OrderEntity Order { get; set; } = null!;


    [Required]
    [ForeignKey(nameof(ProductEntity))]

    public int ProductId { get; set; }

    public virtual ProductEntity Product { get; set; } = null!;



    [Required]
    public int Quantity { get; set; }



    [Required]
    [Column(TypeName = "varchar(max)")]
    public string PriceUnit { get; set; } = null!;



    [Required]
    [Column(TypeName = "varchar(max)")]
    public string Price { get; set; } = null!;


}
