using Microsoft.AspNetCore.Builder;
using OCPI.Exceptions;
using OCPI.Versioning;

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

        //Endpoints
        builder.AddOcpiEndpoints();

        return builder;
    }
}
