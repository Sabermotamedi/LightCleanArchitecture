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
        //var connectionString = configuration.GetConnectionString("DefaultConnection");

        var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
        var dbName = Environment.GetEnvironmentVariable("DB_NAME");
        var dbPassword = Environment.GetEnvironmentVariable("DB_SA_PASSWORD");

        var connectionString = $"Server={dbHost};Database={dbName};User Id=sa;Password={dbPassword};Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True;";
       // var connectionString = $"Data Source={dbHost};Initial Catalog={dbName};User ID=sa;Password={dbPassword}";
        // var connectionString = $"Server=.;Database=lightDb;User Id=sa;Password=123;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True;";

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
