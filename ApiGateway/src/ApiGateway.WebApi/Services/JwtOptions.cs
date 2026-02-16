namespace ApiGateway.WebApi.Services;

public class JwtOptions
{
    public const string SectionName = "Jwt";

    public required string SecretKey { get; init; }
    public int ExpirationMinutes { get; init; } = 60;
}