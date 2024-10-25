namespace Orange.Shared;

public class Topic : EntityBase, ICreator, IModifier
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public TopicStatusEnum Status { get; set; } = TopicStatusEnum.Open;

    public Guid ProjectId { get; set; } = Guid.Empty;

    public Guid CreatorId { get; set; } = Guid.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.MaxValue;
    public Guid ModifierId { get; set; } = Guid.Empty;
    public DateTime ModifiedAt { get; set; } = DateTime.MaxValue;
}