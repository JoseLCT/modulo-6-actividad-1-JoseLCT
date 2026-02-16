using MediatR;
using MsAuth.Application.Interfaces;
using MsAuth.Core.Results;

namespace MsAuth.Application.Login;

public class LoginHandler : IRequestHandler<LoginCommand, Result<LoginResult>>
{
    private readonly IJwtService _jwtService;

    public LoginHandler(IJwtService jwtService)
    {
        _jwtService = jwtService;
    }

    public Task<Result<LoginResult>> Handle(LoginCommand request, CancellationToken ct)
    {
        if (request.Username != "admin" || request.Password != "password")
        {
            return Task.FromResult(Result.Failure<LoginResult>("Invalid username or password"));
        }
        var userId = Guid.NewGuid();
        var token = _jwtService.GenerateToken(userId.ToString());
        var result = new LoginResult { Token = token };
        return Task.FromResult(Result.Success(result));
    }
}