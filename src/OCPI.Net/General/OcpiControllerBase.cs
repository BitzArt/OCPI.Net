using BitzArt.Pagination;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace OCPI;

public abstract class OcpiControllerBase : ControllerBase
{
    public new OkObjectResult Ok() =>
        base.Ok(new OcpiResponse());

    public override OkObjectResult Ok([ActionResultObjectValue] object? value)
    {
        ConfigureIfPageResult(value);
        return base.Ok(new OcpiResponse(value));
    }

    public override CreatedResult Created(string uri, [ActionResultObjectValue] object? value)
    {
        ConfigureIfPageResult(value);
        return base.Created(uri, new OcpiResponse(value));
    }

    public override CreatedResult Created(Uri uri, [ActionResultObjectValue] object? value)
    {
        ConfigureIfPageResult(value);
        return base.Created(uri, new OcpiResponse(value));
    }

    private void ConfigureIfPageResult(object? value)
    {
        if (value is PageResult valuePage) ConfigurePageResult(valuePage);
    }

    private void ConfigurePageResult(PageResult pageResult)
    {
        if (HttpContext == null) return;
        var paginationService = GetService<OcpiPaginationService>()!;
        paginationService.ConfigureResponse(pageResult);
    }

    private TService? GetService<TService>() => HttpContext.RequestServices.GetService<TService>();
}
