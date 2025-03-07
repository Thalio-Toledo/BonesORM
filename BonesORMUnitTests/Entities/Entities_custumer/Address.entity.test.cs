using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BonesCore.DataAnotattions;

namespace BonesORMUnitTests.Entities.Entities_custumer;

[Table("DatabaseName..Address")]
public class Address
{
    [Key]
    public int Id { get; set; }
    public string Street { get; set; } = "";
    public int Number { get; set; } = 0;
    public bool Active { get; set; } = true;
    public DateTime DateCreation { get; set; } = DateTime.Now;

    [ForeignkeyOf("Custumer")]
    public int CustumerId { get; set; }
    public Custumer Custumer { get; set; }

}
