using Microsoft.Extensions.DependencyInjection;
using OCPI.Exceptions;

namespace OCPI.Extensions;

public static class AddOcpiExceptionHandlerExtension
{
    public static IServiceCollection AddOcpiExceptionHandler(this IServiceCollection services)
    {
        return services
            .AddHttpContextAccessor()
            .AddScoped<OcpiExceptionHandler>();
    }
}
