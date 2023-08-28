using BitzArt;
using Microsoft.AspNetCore.Mvc.Filters;

namespace OCPI.Sample;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class OcpiAuthorizeAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var token = GetToken(context.HttpContext.Request);

        // Your authorization logic.
    }

    private static string GetToken(HttpRequest request)
    {
        var authHeaders = request.Headers["Authorization"];

        if (!authHeaders.Any()) throw ApiException.Unauthorized("Authorization header not found");
        if (authHeaders.Count > 1) throw ApiException.Unauthorized("Multiple Authorization headers not allowed.");

        var header = authHeaders.First()!;
        if (string.IsNullOrWhiteSpace(header)) throw ApiException.Unauthorized("Invalid authorization token.");

        var token = header.Split(" ").Last();

        return token;
    }
}
