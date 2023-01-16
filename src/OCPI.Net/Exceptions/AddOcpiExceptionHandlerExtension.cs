using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace OCPI.Exceptions;

public static class AddOcpiExceptionHandlerExtension
{
    public static WebApplicationBuilder AddOcpiExceptionHandler(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddHttpContextAccessor()
            .AddScoped<OcpiExceptionHandler>();

        return builder;
    }
}
