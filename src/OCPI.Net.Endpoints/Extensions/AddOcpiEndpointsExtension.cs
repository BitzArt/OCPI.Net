using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Services;
using System.Reflection;

namespace OCPI.Versioning;

public static class AddOcpiEndpointsExtension
{
    public static WebApplicationBuilder AddOcpiEndpoints(this WebApplicationBuilder builder)
    {
        var currentAssembly = typeof(AddOcpiEndpointsExtension).Assembly;

        var endpointTypes = AppDomain
            .CurrentDomain
            .GetAssemblies()
            .Where(x => x != currentAssembly)
            .SelectMany(x => x.DefinedTypes)
            .Where(x => !x.IsAbstract)
            .Where(x => typeof(OcpiEndpoint).IsAssignableFrom(x));

        foreach (var endpointType in endpointTypes)
        {
            builder.Services.AddScoped(endpointType);
            builder.Services.AddScoped(typeof(OcpiEndpoint), endpointType);
        }

        var endpointTypeCollection = new OcpiEndpointTypeCollection(endpointTypes);
        builder.Services.AddSingleton(endpointTypeCollection);

        builder.Services.AddSingleton<OcpiEndpointMappingService>();
        builder.Services.AddTransient<OcpiEndpointRegisteringService>();

        return builder;
    }
}
