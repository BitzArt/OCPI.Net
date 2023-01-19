using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Services;

namespace OCPI.Versioning;

public static class AddOcpiEndpointsExtension
{
    public static WebApplicationBuilder AddOcpiEndpoints(this WebApplicationBuilder builder)
    {
        var endpointTypes = AppDomain
            .CurrentDomain
            .GetAssemblies()
            .SelectMany(x => x.DefinedTypes)
            .Where(x => typeof(OcpiEndpoint).IsAssignableFrom(x))
            .Where(x => x != typeof(OcpiEndpoint));

        foreach (var endpointType in endpointTypes)
        {
            builder.Services.AddScoped(endpointType);
            builder.Services.AddScoped(typeof(OcpiEndpoint), endpointType);
        }

        var endpointTypeCollection = new OcpiEndpointTypeCollection(endpointTypes);
        builder.Services.AddSingleton(endpointTypeCollection);

        builder.Services.AddSingleton<OcpiEndpointMappingService>();

        return builder;
    }
}
