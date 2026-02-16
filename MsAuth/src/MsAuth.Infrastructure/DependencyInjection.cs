using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MsAuth.Application;
using MsAuth.Application.Interfaces;
using MsAuth.Infrastructure.Services.Jwt;

namespace MsAuth.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddApplication();
        services.AddOptions<JwtOptions>()
            .Bind(configuration.GetSection(JwtOptions.SectionName));

        services.AddSingleton<IJwtService, JwtService>();

        return services;
    }
}