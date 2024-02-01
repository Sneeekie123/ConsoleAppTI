using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppTI.Entities;

public class OrderEntity
{

    [Key]
    public int OrderId { get; set; }


    public virtual ICollection<CustomerEntity> Customers { get; set; } = new HashSet<CustomerEntity>();

}
