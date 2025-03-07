using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BonesCore.DataAnotattions;

namespace BonesORMUnitTests.Entities.Entities_custumer;

[Table("DatabaseName..Item")]
public class Item
{
    [Key]
    public Guid Id { get; set; }

    [ForeignkeyOf("Order")]
    public int OrderId { get; set; }
    public Order Order { get; set; }

    [ForeignkeyOf("Product")]
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
}
