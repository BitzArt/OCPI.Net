using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace OCPI.Exceptions;

public static class AddOcpiExceptionHandlerExtension
{
    public static WebApplicationBuilder AddOcpiExceptionHandler(this WebApplicationBuilder builder)
    {
        builder.Services.AddOcpiExceptionHandler();
        return builder;
    }

    public static IServiceCollection AddOcpiExceptionHandler(this IServiceCollection services)
    {
        return services
            .AddHttpContextAccessor()
            .AddScoped<OcpiExceptionHandler>();
    }
}
