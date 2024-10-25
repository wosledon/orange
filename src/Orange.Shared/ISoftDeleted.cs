namespace Orange.Shared;

public interface ISoftDeleted
{
    bool IsDeleted { get; set; }
}