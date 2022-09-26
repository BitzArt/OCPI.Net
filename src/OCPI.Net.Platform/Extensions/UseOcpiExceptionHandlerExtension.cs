using BitzArt.ApiExceptions.AspNetCore;
using Microsoft.AspNetCore.Builder;
using OCPI.Exceptions;

namespace OCPI.Extensions;

public static class UseOcpiExceptionHandlerExtension
{
    public static void UseOcpiExceptionHandler(this IApplicationBuilder app)
    {
        app.UseMiddleware<ApiExceptionHandlingMiddleware<OcpiExceptionHandler>>();
    }
}
