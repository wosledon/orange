namespace Orange.Shared;

public class TopicFlow : EntityBase, ICreator, IModifier
{
    public Guid TopicId { get; set; } = Guid.Empty;

    public bool IsPicked { get; set; } = false;
    
    public Guid CreatorId { get; set; } = Guid.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.MaxValue;
    public Guid ModifierId { get; set; } = Guid.Empty;
    public DateTime ModifiedAt { get; set; } = DateTime.MaxValue;
}