namespace ConnectLibrary.Application.UseCases.User.Responses;

public sealed record DefaultUserResponse()
{
    public Guid Id { get; init; }
    public string Username { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
}