using BitzArt.Pagination;
using Microsoft.AspNetCore.Http;

namespace OCPI;

internal class PageResponseService
{
    private readonly HttpContext _httpContext;
    private readonly OcpiOptions _options;

    public PageResponseService(IHttpContextAccessor httpContextAccessor, OcpiOptions options)
    {
        _httpContext = httpContextAccessor.HttpContext!;
        _options = options;
    }

    public void ConfigureResponse(PageResult pageResult)
    {
        if (_httpContext is null) return;

        _httpContext.Response.Headers.Add("X-Total-Count", pageResult.Total.ToString());
        _httpContext.Response.Headers.Add("X-Limit", pageResult.Request!.Limit.ToString());

        _httpContext.Response.Headers.Add("Link", "-NotImplemented-");
    }
}
