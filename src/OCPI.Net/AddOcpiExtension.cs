using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OCPI;
using OCPI.Exceptions;
using OCPI.Versioning;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Design", "CA1050:Declare types in namespaces")]
public static class AddOcpiExtension
{
    public static WebApplicationBuilder AddOcpi(this WebApplicationBuilder builder)
    {
        builder.Services.AddOcpi(builder.Configuration);
        return builder;
    }

    public static IServiceCollection AddOcpi(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddOcpiOptions(configuration);
        services.AddOcpiExceptionHandler();
        services.AddOcpiVersioning();
        return services;
    }
}
