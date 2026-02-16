using MediatR;
using MsAuth.Core.Results;

namespace MsAuth.Application.Login;

public record LoginCommand : IRequest<Result<LoginResult>>
{
    public required string Username { get; init; }
    public required string Password { get; init; }
}