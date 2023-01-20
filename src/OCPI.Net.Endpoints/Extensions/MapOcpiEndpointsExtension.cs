using Microsoft.AspNetCore.Builder;
using OCPI.Services;

namespace OCPI;

public static class UseOcpiEndpointsExtension
{
    public static WebApplication MapOcpiEndpoints(this WebApplication app)
    {
        var registrator = app.GetService<OcpiEndpointRegisteringService>();

        registrator.RegisterOcpiEndpoints(app);

        return app;
    }
}
