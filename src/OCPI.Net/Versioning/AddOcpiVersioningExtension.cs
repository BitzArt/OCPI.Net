using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace OCPI.Versioning;

public static class AddOcpiVersioningExtension
{
    public static WebApplicationBuilder AddOcpiVersioning(this WebApplicationBuilder builder)
    {
        builder.Services.AddOcpiVersioning();
        return builder;
    }

    public static IServiceCollection AddOcpiVersioning(this IServiceCollection services)
    {
        return services;
    }
}
