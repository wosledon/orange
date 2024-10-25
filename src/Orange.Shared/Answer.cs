namespace Orange.Shared;

public class Answer : EntityBase, ICreator, IModifier
{
    public string Content { get; set; } = string.Empty;

    public Guid QuestionId { get; set; }

    public Guid CreatorId { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid ModifierId { get; set; }
    public DateTime ModifiedAt { get; set; }
}