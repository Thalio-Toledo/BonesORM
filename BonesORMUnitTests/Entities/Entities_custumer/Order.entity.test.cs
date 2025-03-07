using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BonesCore.DataAnotattions;
using BonesORMUnitTests.Entities.Entities_custumer.Enums;

namespace BonesORMUnitTests.Entities.Entities_custumer;

[Table("DatabaseName..Order")]
public class Order
{
    [Key]
    public int Id { get; set; }
    public DateTime CreationDate { get; set; }
    public Status Status { get; set; }

    [ForeignkeyOf("Custumer")]
    public int CustumerId { get; set; }
    public Custumer Custumer { get; set; }
    public List<Item> Items { get; set; }
}
