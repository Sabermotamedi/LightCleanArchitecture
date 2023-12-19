using LightCleanArchitecture.Application.Common.Interfaces.Services;
using LightCleanArchitecture.Application.Services;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {        
        //services.AddAutoMapper(Assembly.GetExecutingAssembly());


        services.AddScoped<ITodoItemService, TodoItemService>();
        services.AddScoped<ITodoListService, TodoListService>();

        return services;
    }
}

