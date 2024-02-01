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


    public virtual ICollection<ProductEntity> Products { get; set; } = new HashSet<ProductEntity>();


}


