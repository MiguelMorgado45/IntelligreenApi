using Intelligreen.Application;
using Intelligreen.Application.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Intelligreen.Persistence.IoC;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddIdentityDbContext(this IServiceCollection services)
    {
        services.AddDbContext<IdentityContext>(options => options.UseInMemoryDatabase("IdentityDb"));

        return services;
    }

    public static IServiceCollection AddAppDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => options
            .UseNpgsql(
                configuration.GetConnectionString("AppDbConnectionString"),
                b => b.MigrationsAssembly("Intelligreen.Persistence")));

        return services;
    }
}