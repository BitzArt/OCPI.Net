using BitzArt.Pagination;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Contracts;
using OCPI.Services;
using OCPI.Validation;

namespace OCPI;

public abstract class OcpiControllerBase : ControllerBase
{
    [NonAction]
    public OkObjectResult OcpiOk([ActionResultObjectValue] object? value)
    {
        if (value is null) return base.Ok(new OcpiResponse());

        if (value is PageResult)
        {
            throw new InvalidOperationException("This method was deprecated for PageResult types. Use OcpiOk<T>(PageResult<T> value) instead.");
        }

        return base.Ok(new OcpiResponse(value));
    }

    [NonAction]
    public OkObjectResult OcpiOk<T>([ActionResultObjectValue] PageResult<T> value)
    {
        ConfigurePageResult(value);
        return base.Ok(new OcpiResponse(value.Items));
    }

    [NonAction]
    public void OcpiValidate<T>(T value, OcpiVersion forOcpiVersion)
    {
        if (value is null) return;

        var validationContext = GetRequiredService<OcpiValidationContext>();
        validationContext.OcpiVersion = forOcpiVersion;

        var validator = GetRequiredService<IOcpiValidator<T>>();
        var validationResult = validator.Validate(value);

        if (!validationResult.IsValid)
        {
            var exception = OcpiException.InvalidParameters();
            var errors = validationResult.Errors.Select(x => x.ErrorMessage);
            exception.Payload.AddData(new { errors });
            throw exception;
        }
    }

    [NonAction]
    public void OcpiValidate<T>(T value)
    {
        if (value is null) return;
        var validator = GetRequiredService<IOcpiValidator<T>>();
        var validationResult = validator.Validate(value);

        if (!validationResult.IsValid)
        {
            var exception = OcpiException.InvalidParameters();
            var errors = validationResult.Errors.Select(x => x.ErrorMessage);
            exception.Payload.AddData(new { errors });
            throw exception;
        }
    }

    [NonAction]
    public void SetMaxLimit(PageRequest pageRequest, int max)
    {
        if (pageRequest.Limit > max)
        {
            pageRequest.Limit = max;
        }
        HttpContext.Items["OcpiRequestMaxLimitValue"] = max;
    }

    private void ConfigurePageResult<T>(PageResult<T> pageResult)
    {
        if (HttpContext is null) return;

        if (pageResult is not PageResult<T, OcpiPageRequest> typedPageResult)
        {
            throw new NotSupportedException("Unexpected PageRequest type.");
        }

        var paginationService = GetRequiredService<PageResponseService>();
        paginationService.ConfigureResponse(typedPageResult);
    }

    private TService GetRequiredService<TService>()
        where TService : class =>
        HttpContext.RequestServices.GetRequiredService<TService>()!;
}
