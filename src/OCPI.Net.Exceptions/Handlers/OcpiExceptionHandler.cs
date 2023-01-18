using BitzArt.ApiExceptions;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;

namespace OCPI.Exceptions;

public class OcpiExceptionHandler : IApiExceptionHandler
{
    private readonly HttpContext _httpContext;

    public OcpiExceptionHandler(IHttpContextAccessor contextAccessor)
    {
        _httpContext = contextAccessor.HttpContext!;
    }

    public async Task HandleAsync(Exception exception)
    {
        _httpContext.Response.StatusCode = GetHttpStatusCode(exception);
        _httpContext.Response.ContentType = "application/json";

        var response = JsonSerializer.Serialize(exception.ToOcpiResponse());
        await _httpContext.Response.WriteAsync(response);
    }

    private static int GetHttpStatusCode(Exception exception)
    {
        if (exception is ApiExceptionBase apiException) return apiException.StatusCode;
        return (int)HttpStatusCode.InternalServerError;
    }
}
