using BitzArt.ApiExceptions;
using BitzArt.ApiExceptions.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Text.Json;

namespace OCPI.Exceptions;

public class OcpiExceptionHandler : IApiExceptionHandler
{
    private readonly ApiExceptionHandlerOptions _options;
    private readonly HttpContext _httpContext;
    private readonly JsonOptions _jsonOptions;
    private readonly ILogger _logger;

    public OcpiExceptionHandler(
        IHttpContextAccessor contextAccessor,
        IOptions<JsonOptions> jsonOptions,
        ApiExceptionHandlerOptions options,
        ILogger<IApiExceptionHandler> logger)
    {
        _httpContext = contextAccessor.HttpContext!;
        _jsonOptions = jsonOptions.Value;
        _options = options;
        _logger = logger;
    }

    public async Task HandleAsync(Exception exception)
    {
        _httpContext.Response.StatusCode = exception.GetHttpStatusCode();
        _httpContext.Response.ContentType = "application/json";

        var response = JsonSerializer.Serialize(exception.ToOcpiResponse(), _jsonOptions.SerializerOptions);
        await _httpContext.Response.WriteAsync(response);

        if (_options.EnableRequestLogging)
        {
            var req = _httpContext.Request;
            _logger.LogInformation("{timestamp} {method} {path} : {statusCode}", string.Format("{0:u}", DateTime.Now), req.Method, req.Path, _httpContext.Response.StatusCode);
            if (_options.EnableErrorLogging)
            {
                _logger.LogError("{exception}", exception.ToStringDemystified());
            }
        }
    }
}
