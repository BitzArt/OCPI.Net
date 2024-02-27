using Microsoft.AspNetCore.Builder;

namespace OCPI;

public static class AddOcpiExtension
{
    public static WebApplicationBuilder AddOcpi(this WebApplicationBuilder builder)
    {
        builder.ConfigureOcpiJson();

        builder.AddOcpiControllers();
        builder.AddOcpiVersioning();

        builder.Services.AddOcpiValidationContext();
        builder.Services.AddOcpiValidation();

        return builder;
    }
}
