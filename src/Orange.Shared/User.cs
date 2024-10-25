namespace Orange.Shared;

public class User : EntityBase, IEnabled
{
    public string Name { get; set; } = string.Empty;
    public string Account { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Avatar { get; set; } = string.Empty;

    // ReSharper disable once MemberCanBePrivate.Global
    public RoleEnum Role { get; set; } = RoleEnum.User;

    public bool IsEnabled { get; set; } = true;

    public bool IsAdmin => Role == RoleEnum.Admin;
}