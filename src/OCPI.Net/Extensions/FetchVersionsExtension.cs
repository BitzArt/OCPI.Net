using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Services;

namespace OCPI.Versioning;

public static class FetchVersionsExtension
{
    public static WebApplication FetchVersions(this WebApplication app)
    {
        app.GetService<OcpiVersionService>();

        return app;
    }
}
