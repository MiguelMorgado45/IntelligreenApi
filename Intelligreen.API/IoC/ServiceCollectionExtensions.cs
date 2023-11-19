using System.Text;
using Intelligreen.Application.Identity;
using Intelligreen.Domain;
using Intelligreen.Persistence.IoC;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Intelligreen.API.IoC;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddJwtBearer(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata= false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    ValidAudience = configuration["JWT:ValidAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]!))
                };
            });
        
        return services;
    }

    public static IServiceCollection AddIdentityUtils(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddAppDbContext(configuration);
        services.AddIdentityDbContext();

        services
            .AddIdentityCore<Usuario>()
            .AddEntityFrameworkStores<IdentityContext>()
            .AddDefaultTokenProviders();

        services.Configure<IdentityOptions>(options =>
        {
            options.Password.RequiredLength = 3;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase= false;
            options.Password.RequireUppercase= false;
            options.Password.RequireNonAlphanumeric= false;
            options.SignIn.RequireConfirmedEmail = false;
        });

        return services;
    }
}