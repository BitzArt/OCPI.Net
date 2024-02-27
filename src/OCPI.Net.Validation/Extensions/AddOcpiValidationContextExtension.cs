using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Validation;

namespace OCPI;

public static class AddOcpiValidationContextExtension
{
    public static IServiceCollection AddOcpiValidationContext(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        services.AddTransient(x => x.GetRequiredService<IHttpContextAccessor>()!.HttpContext!);

        services.AddScoped(x =>
        {
            var httpContext = x.GetRequiredService<HttpContext>();
            var request = httpContext.Request;

            return new OcpiValidationContext(request);
        });

        return services;
    }
}
