using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Exceptions;
using OCPI.Versioning;

namespace OCPI;

public static class AddOcpiExtension
{
    public static WebApplicationBuilder AddOcpi(this WebApplicationBuilder builder)
    {
        builder.AddOcpiOptions();
        builder.ConfigureOcpiJson();
        builder.AddOcpiControllers();
        builder.AddOcpiVersioning();
        builder.AddOcpiExceptionHandler();
        builder.AddOcpiValidation();

        return builder;
    }
}
