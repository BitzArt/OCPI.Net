using BitzArt.ApiExceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace OCPI.Exceptions;

public class OcpiExceptionHandler : IApiExceptionHandler
{
    private readonly HttpContext _httpContext;
    private readonly JsonOptions _jsonOptions;

    public OcpiExceptionHandler(IHttpContextAccessor contextAccessor, IOptions<JsonOptions> jsonOptions)
    {
        _httpContext = contextAccessor.HttpContext!;
        _jsonOptions = jsonOptions.Value;
    }

    public async Task HandleAsync(Exception exception)
    {
        _httpContext.Response.StatusCode = exception.GetHttpStatusCode();
        _httpContext.Response.ContentType = "application/json";

        var response = JsonSerializer.Serialize(exception.ToOcpiResponse(), _jsonOptions.SerializerOptions);
        await _httpContext.Response.WriteAsync(response);
    }
}
