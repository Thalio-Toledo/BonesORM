using BonesCore.utils;
using BonesCoreOrm.Generators;
using BonesORMUnitTests.Entities.Entities_custumer;
using FluentAssertions;
using static BonesCore.Models.GroupByModel;

namespace BonesORMUnitTests.Delete_orm_tests;

public class DeleteTests
{
    [Fact]
    public async Task Generate_Delete()
    {
        //Arrange  
        var options = new Config();

        var table = new Custumer() { Id = 1, Name = "Custumer", AddressId = 1, Active = true };
        options.SetEntity(typeof(Custumer));

        var delete = new DeleteGen(options);
        string query = @""" DELETE DatabaseName..Custumer
                            WHERE  
                             Id = 1  """;

        //Assert
        var result = delete.Generate(table);

        // Act & Assert
        result.NormalizeQuery().Should().Be(query.NormalizeQuery());
    }
}
