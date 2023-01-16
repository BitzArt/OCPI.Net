using BitzArt.Pagination;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace OCPI;

internal class OcpiPaginationService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly OcpiOptions _options;

    public OcpiPaginationService(IHttpContextAccessor httpContextAccessor, IOptions<OcpiOptions> options)
    {
        _httpContextAccessor = httpContextAccessor;
        _options = options.Value;
    }

    public void ConfigureResponse(PageResult pageResult)
    {
        var httpContext = _httpContextAccessor.HttpContext;
        if (httpContext == null) return;

        var next = "-NotImplemented-";
        if (next != null) httpContext.Response.Headers.Add("Link", next);
        if (next == null) httpContext.Response.Headers.Add("X-Last-Page", true.ToString());

        httpContext.Response.Headers.Add("X-Total-Count", pageResult.Total.ToString());
        httpContext.Response.Headers.Add("X-Limit", pageResult.Request!.Limit.ToString());
    }
}
