#pragma warning disable CA1050 // Declare types in namespaces
using Microsoft.AspNetCore.Builder;
using OCPI;

public static class AddOcpiExtension
#pragma warning restore CA1050 // Declare types in namespaces
{
    public static WebApplicationBuilder AddOcpi(this WebApplicationBuilder builder)
    {
        builder.AddOcpiExceptionHandler();
        builder.AddOcpiVersioning();

        return builder;
    }
}
