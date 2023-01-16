using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace OCPI;

internal class ValidatorInterceptor : IValidatorInterceptor
{
    public IValidationContext BeforeAspNetValidation(ActionContext actionContext, IValidationContext commonContext)
    {
        return commonContext;
    }

    public ValidationResult AfterAspNetValidation(ActionContext actionContext, IValidationContext validationContext,
        ValidationResult result)
    {
        if (result.IsValid) return result;

        var data = new { errors = result.Errors.Select(x => x.ErrorMessage) };
        var dataSerialized = JsonSerializer.Serialize(data);
        throw OcpiException.InvalidParameters(dataSerialized);
    }
}
