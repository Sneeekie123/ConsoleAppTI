using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ConsoleAppTI.Entities;

public class PriceEntity
{
    [Key]
    public int PriceId { get; set; }

    [Required]
    [ForeignKey(nameof(ProductEntity))]
    public int ProductId { get; set; }

    public virtual ProductEntity Product { get; set; } = null!;
    
    [Required]
    [Column(TypeName = "money")]
    public string Price { get; set; } = null!;

    [Required]
    [Column(TypeName = "datetime2")]
    public DateTime PriceDate { get; set; } 

    public virtual ICollection<ProductEntity> Products { get; set; } = new HashSet<ProductEntity>();


}


