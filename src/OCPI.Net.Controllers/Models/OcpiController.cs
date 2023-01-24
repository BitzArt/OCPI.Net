using BitzArt.Pagination;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Services;

namespace OCPI;

[ApiController]
public abstract class OcpiController : ControllerBase
{
    public OkObjectResult OcpiOk([ActionResultObjectValue] object? value)
    {
        if (value is null) return base.Ok(new OcpiResponse());

        if (value is PageResult valuePage)
        {
            ConfigurePageResult(valuePage);
            return base.Ok(new OcpiResponse(valuePage.Data));
        }

        return base.Ok(new OcpiResponse(value));
    }

    private void ConfigurePageResult(PageResult pageResult)
    {
        if (HttpContext is null) return;
        var paginationService = GetService<PageResponseService>()!;
        paginationService.ConfigureResponse(pageResult);
    }

    private TService? GetService<TService>() => HttpContext.RequestServices.GetService<TService>();
}
