namespace Orange.Shared;

public interface IModifier
{
    Guid ModifierId { get; set; }
    DateTime ModifiedAt { get; set; }
}