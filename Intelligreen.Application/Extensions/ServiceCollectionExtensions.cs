using Microsoft.Extensions.DependencyInjection;

namespace Intelligreen.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMediatR(this IServiceCollection services)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssemblyContaining<ApplicationDbContext>();
        });
        
        return services;
    }
}