using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Services;

namespace OCPI;

public static class UseOcpiEndpointsExtension
{
    public static WebApplication MapOcpiEndpoints(this WebApplication app)
    {
        var mapper = (app.Services.CreateScope().ServiceProvider
            .GetService(typeof(OcpiEndpointMappingService))
            as OcpiEndpointMappingService)!;

        var registrator = new OcpiEndpointRegisteringService(mapper);
        registrator.RegisterOcpiEndpoints(app);

        return app;
    }
}
