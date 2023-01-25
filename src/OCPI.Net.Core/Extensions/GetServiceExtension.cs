using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace OCPI;

public static class GetServiceExtension
{
    public static T GetService<T>(this WebApplication app)
        where T : class
    {
        using var scope = app.Services.CreateScope();
        return (scope.ServiceProvider.GetService(typeof(T)) as T)!;
    }
}
