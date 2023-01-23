using Microsoft.AspNetCore.Builder;
using OCPI.Versioning;

namespace OCPI;
public static class UseOcpiExtension
{
    public static WebApplication UseOcpi(this WebApplication app)
    {
        app.UseOcpiExceptionHandler();
        app.MapControllers();
        app.FetchVersions();

        return app;
    }
}
