using Microsoft.AspNetCore.Builder;

namespace OCPI;

public static class AddOcpiVersioningExtension
{
    public static WebApplicationBuilder AddOcpiVersioning(this WebApplicationBuilder builder)
    {
        return builder;
    }
}
