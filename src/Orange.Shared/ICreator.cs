namespace Orange.Shared;

public interface ICreator
{
    Guid CreatorId { get; set; }
    DateTime CreatedAt { get; set; }
}