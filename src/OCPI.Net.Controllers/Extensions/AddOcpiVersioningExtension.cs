using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Versioning.Services;

namespace OCPI;

public static class AddOcpiVersioningExtension
{
    public static WebApplicationBuilder AddOcpiVersioning(this WebApplicationBuilder builder)
    {
        builder.AddOcpiOptions();

        builder.Services.AddSingleton<IOcpiVersionService, OcpiVersionService>();

        return builder;
    }
}
