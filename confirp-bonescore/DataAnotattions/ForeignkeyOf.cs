namespace BonesCore.DataAnotattions;

[AttributeUsage(AttributeTargets.Property)]
public class ForeignkeyOf : Attribute
{
    public string EntityName { get; }

    public ForeignkeyOf(string entityName)
    {
        EntityName = entityName;
    }
}