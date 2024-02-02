using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ConsoleAppTI.Entities;

public class PriceEntity
{
    [Key]
    public int PriceId { get; set; }

  
    [Required]
    [Column(TypeName = "varchar(max)")]
    public string Price { get; set; } = null!;

    [Required]
    [Column(TypeName = "DateTime2")]
    public DateTime PriceDate { get; set; } 

    public virtual ICollection<ProductEntity> Products { get; set; } = new HashSet<ProductEntity>();


}


