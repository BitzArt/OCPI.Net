using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Services;

namespace OCPI.Versioning;

public static class AddOcpiEndpointsExtension
{
    public static WebApplicationBuilder AddOcpiEndpoints(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<OcpiEndpointMappingService>();

        return builder;
    }
}
