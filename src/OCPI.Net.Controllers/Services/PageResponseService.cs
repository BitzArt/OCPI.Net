using BitzArt.Pagination;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Web;

namespace OCPI.Services;

internal class PageResponseService
{
    private readonly HttpContext _httpContext;
    private readonly OcpiOptions _options;
    private readonly IOcpiVersionService _versionService;

    public PageResponseService(IHttpContextAccessor httpContextAccessor, OcpiOptions options, IOcpiVersionService versionService)
    {
        _httpContext = httpContextAccessor.HttpContext!;
        _options = options;
        _versionService = versionService;
    }

    public void ConfigureResponse(PageResult pageResult)
    {
        if (_httpContext is null) return;

        _httpContext.Response.Headers.Add("X-Total-Count", pageResult.Total.ToString());

        var maxLimit = _httpContext.Items["OcpiRequestMaxLimitValue"];
        if (maxLimit is null) throw new Exception("Unable to find MaxLimit value for this request. Make sure SetMaxLimit is used in a controller method.");
        _httpContext.Response.Headers.Add("X-Limit", maxLimit.ToString());

        AddNextPageLink(pageResult);
    }

    private void AddNextPageLink(PageResult pageResult)
    {
        var fetched = pageResult.Request!.Offset!.Value + pageResult.Count!.Value;
        var limit = pageResult.Request!.Limit!.Value;
        var total = pageResult.Total!.Value;

        if (fetched == total) return;

        var query = HttpUtility.ParseQueryString(_httpContext.Request.QueryString.ToString());
        query["offset"] = fetched.ToString();

        var entriesLeft = total - fetched;
        var nextLimit = entriesLeft > limit ? limit : entriesLeft;
        query["limit"] = nextLimit.ToString();

        var nextPageLink = $"{_options.BaseServiceUrl}{_httpContext.Request.Path}?{query.ToString()}";

        _httpContext.Response.Headers.Add("Link", nextPageLink);
    }
}
