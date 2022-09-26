﻿using Microsoft.Extensions.DependencyInjection;
using OCPI.Exceptions;

namespace OCPI;

public static class AddOcpiExceptionHandlerExtension
{
    public static IServiceCollection AddOcpiExceptionHandler(this IServiceCollection services)
    {
        return services
            .AddHttpContextAccessor()
            .AddScoped<OcpiExceptionHandler>();
    }
}