namespace Orange.Shared;

public class Question : EntityBase, ICreator, IModifier
{
    public Guid TopicId { get; set; } = Guid.Empty;

    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;

    public Guid CreatorId { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid ModifierId { get; set; }
    public DateTime ModifiedAt { get; set; }
}