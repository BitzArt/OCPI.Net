using Microsoft.AspNetCore.Builder;

namespace OCPI.Versioning;

public static class FetchVersionsExtension
{
    public static WebApplication FetchVersions(this WebApplication app)
    {
        app.GetService<IOcpiVersionService>();

        return app;
    }
}
