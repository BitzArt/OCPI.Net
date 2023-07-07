using Microsoft.AspNetCore.Builder;

namespace OCPI;

public static class FetchOcpiVersionsExtension
{
    public static WebApplication FetchOcpiVersions(this WebApplication app)
    {
        app.GetService<IOcpiVersionService>();

        return app;
    }
}
