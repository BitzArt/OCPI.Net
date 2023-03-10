using BitzArt.Pagination;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Services;

namespace OCPI;

public abstract class OcpiControllerBase : ControllerBase
{
    [NonAction]
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

    [NonAction]
    public void OcpiValidate<T>(T value)
    {
        if (value is null) return;
        var validator = GetRequiredService<ActionValidator<T>>();
        var validationResult = validator.Validate(value);

        if (!validationResult.IsValid)
        {
            var exception = OcpiException.InvalidParameters();
            var errors = validationResult.Errors.Select(x => x.ErrorMessage);
            exception.Payload.AddData(new { errors });
            throw exception;
        }
    }

    private void ConfigurePageResult(PageResult pageResult)
    {
        if (HttpContext is null) return;
        var paginationService = GetRequiredService<PageResponseService>();

        paginationService.ConfigureResponse(pageResult);
    }

    private TService GetRequiredService<TService>()
        where TService : class =>
        HttpContext.RequestServices.GetRequiredService<TService>()!;
}
