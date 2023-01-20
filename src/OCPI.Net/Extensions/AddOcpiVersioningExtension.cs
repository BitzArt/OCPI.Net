using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Services;

namespace OCPI.Extensions;
public static class AddOcpiVersioningExtension
{
    public static WebApplicationBuilder AddOcpiVersioning(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IOcpiVersionService, OcpiVersionService>();

        return builder;
    }
}
