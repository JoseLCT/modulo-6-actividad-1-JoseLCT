namespace MsAuth.Application.Login;

public record LoginResult
{
    public required string Token { get; init; }
}