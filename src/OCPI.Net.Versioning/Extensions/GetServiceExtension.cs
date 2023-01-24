using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace OCPI;

internal static class GetServiceExtension
{
    public static T GetService<T>(this WebApplication app)
        where T : class =>
        (app.Services.CreateScope().ServiceProvider.GetService(typeof(T)) as T)!;
}
