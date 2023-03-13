using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace OCPI;

public static class AddOcpiValidationExtension
{
    private interface IOcpiValidatorsAssemblyPointer { }

    public static WebApplicationBuilder AddOcpiValidation(this WebApplicationBuilder builder, Action<FluentValidationAutoValidationConfiguration>? validationConfigurationExpression = null)
    {
        builder.Services.AddHttpContextAccessor();
        builder.Services.AddTransient(x => x.GetRequiredService<IHttpContextAccessor>()!.HttpContext!);

        var validatorTypes = typeof(IOcpiValidatorsAssemblyPointer)
            .Assembly.DefinedTypes
            .Where(x => !x.IsAbstract)
            .Select(x => x.DeclaringType)
            .Where(x => x!.IsSubclassOfRawGeneric(typeof(ActionValidator<>)));

        foreach (var type in validatorTypes)
        {
            var modelType = type!.BaseType!.GenericTypeArguments.First();
            var resultingType = typeof(ActionValidator<>).MakeGenericType(modelType);
            builder.Services.AddScoped(resultingType, x =>
            {
                var actionType = x.GetRequiredService<HttpContext>().Request.Method.ToActionType();
                var instance = Activator.CreateInstance(type, actionType);
                return instance!;
            });
        }

        return builder;
    }
}

internal static class TypeExtensions
{
    internal static bool IsSubclassOfRawGeneric(this Type toCheck, Type generic)
    {
        while (toCheck != null && toCheck != typeof(object))
        {
            var cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
            if (generic == cur)
            {
                return true;
            }
            toCheck = toCheck.BaseType!;
        }
        return false;
    }
}
