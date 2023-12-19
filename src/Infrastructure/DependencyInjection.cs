using LightCleanArchitecture.Application.Common.Interfaces;
using LightCleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration, string databaseProvider)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<ApplicationDbContext>((sp, options) =>
        {
            options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());

            switch (databaseProvider.ToLower())
            {
                case "sqlserver":
                    options.UseSqlServer(connectionString);
                    break;

                case "postgresql":
                    options.UseNpgsql(connectionString);
                    break;

                case "sqlite":
                    options.UseSqlite(connectionString);
                    // Additional SQLite configurations if needed
                    break;

                default:
                    throw new ArgumentException($"Unsupported database provider: {databaseProvider}");
            }

            // Common configurations
            // options.UseSomeCommonConfiguration();

        });

        services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

        return services;
    }
}
