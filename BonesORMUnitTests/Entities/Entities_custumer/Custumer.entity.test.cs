using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BonesCore.DataAnotattions;

namespace BonesORMUnitTests.Entities.Entities_custumer;

[Table("DatabaseName..Custumer")]
public class Custumer
{
    [Key]
    public long Id { get; set; } = 0;
    public string Name { get; set; } = "";
    public bool Active { get; set; } = true;
    public DateTime Date { get; set; }

    [ForeignkeyOf("Address")]
    public int AddressId { get; set; } = 0;
    public Address Address { get; set; }
    public List<Order> Orders { get; set; }
}
