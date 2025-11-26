using BitzArt.Pagination;
using Microsoft.AspNetCore.Http;
using System.Web;

namespace OCPI.Services;

internal class PageResponseService(IHttpContextAccessor httpContextAccessor, OcpiOptions options)
{
    private readonly HttpContext _httpContext = httpContextAccessor.HttpContext!;

    public void ConfigureResponse<TData, TRequest>(PageResult<TData, TRequest> pageResult)
        where TRequest : OcpiPageRequest
    {
        if (_httpContext is null) return;

        _httpContext.Response.Headers.Append("X-Total-Count", pageResult.Total.ToString());

        var maxLimit = _httpContext.Items["OcpiRequestMaxLimitValue"]
            ?? throw new Exception("Unable to find MaxLimit value for this request. Make sure SetMaxLimit is used in a controller method.");
        _httpContext.Response.Headers.Append("X-Limit", maxLimit.ToString());

        AddNextPageLink(pageResult);
    }

    private void AddNextPageLink<TData, TRequest>(PageResult<TData, TRequest> pageResult)
        where TRequest : OcpiPageRequest
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

        var nextPageLink = $"{options.BaseServiceUrl}{_httpContext.Request.Path}?{query}";
        var linkHeader = $"<{nextPageLink}>; rel=\"next\"";

        _httpContext.Response.Headers.Append("Link", linkHeader);
    }
}
