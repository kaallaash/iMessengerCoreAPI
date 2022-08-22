using iMessenger.Contract;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace iMessenger;

public static class Registration
{
    public static IServiceCollection AddRGDialogsClientsService(
        this IServiceCollection services)
    {
        services.AddScoped<IRGDialogsClientsService, RGDialogsClientsService>();

        return services;
    }
}
