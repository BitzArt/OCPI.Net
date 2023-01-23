using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace OCPI;

public static class AddOcpiValidationExtension
{
    private class Pointer { }

    public static WebApplicationBuilder AddOcpiValidation(this WebApplicationBuilder builder, Action<FluentValidationAutoValidationConfiguration>? validationConfigurationExpression = null)
    {
        builder.Services.AddFluentValidationAutoValidation(validationConfigurationExpression);

        builder.Services.AddValidatorsFromAssemblyContaining<Pointer>();

        builder.Services.AddTransient<IValidatorInterceptor, ValidatorInterceptor>();

        return builder;
    }
}
