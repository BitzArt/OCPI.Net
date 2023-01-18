using Microsoft.AspNetCore.Builder;
using OCPI;
using OCPI.Exceptions;
using OCPI.Versioning;
using System.Diagnostics.CodeAnalysis;

namespace OCPI;

public static class AddOcpiExtension
{
    public static WebApplicationBuilder AddOcpi(this WebApplicationBuilder builder)
    {
        // General
        builder.AddOcpiOptions();
        builder.AddOcpiValidation();

        //Exceptions
        builder.AddOcpiExceptionHandler();

        //Versioning
        builder.AddOcpiVersioning();

        return builder;
    }
}
