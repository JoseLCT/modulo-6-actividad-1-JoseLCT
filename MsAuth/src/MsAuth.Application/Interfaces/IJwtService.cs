namespace MsAuth.Application.Interfaces;

public interface IJwtService
{
    string GenerateToken(string userId);
}