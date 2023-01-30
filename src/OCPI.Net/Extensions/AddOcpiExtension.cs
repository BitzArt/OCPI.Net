﻿using Microsoft.AspNetCore.Builder;
using OCPI.Exceptions;

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