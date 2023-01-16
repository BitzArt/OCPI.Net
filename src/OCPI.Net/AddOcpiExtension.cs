using Microsoft.AspNetCore.Builder;
using OCPI;
using OCPI.Exceptions;
using OCPI.Versioning;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Design", "CA1050:Declare types in namespaces")]
public static class AddOcpiExtension
{
    public static WebApplicationBuilder AddOcpi(this WebApplicationBuilder builder)
    {
        // General
        builder.AddOcpiControllers();
        builder.ConfigureOcpiJson();
        builder.AddOcpiOptions();
        builder.AddOcpiValidation();

        //Exceptions
        builder.AddOcpiExceptionHandler();

        //Versioning
        builder.AddOcpiVersioning();

        return builder;
    }
}
