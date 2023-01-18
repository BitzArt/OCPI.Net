using Microsoft.AspNetCore.Builder;

namespace OCPI.Versioning;

public static class AddOcpiVersioningExtension
{
    public static WebApplicationBuilder AddOcpiVersioning(this WebApplicationBuilder builder)
    {
        return builder;
    }
}
