using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Contracts;
using OCPI.Validation;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.Json.Serialization;

namespace OCPI;

public static class AddOcpiValidationExtension
{
    private interface IOcpiValidatorsAssemblyPointer { }

    public static IServiceCollection AddOcpiValidation(this IServiceCollection services)
    {
        ValidatorOptions.Global.PropertyNameResolver =
            (_, member, _) =>
                member?.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name ?? member?.Name;

        var validatorTypes = typeof(IOcpiValidatorsAssemblyPointer)
            .Assembly.DefinedTypes
            .Where(x => !x.IsAbstract)
            .Select(x => x.DeclaringType)
            .Where(x => x!.IsSubclassOfRawGeneric(typeof(OcpiValidator<>)) && x!.IsGenericType == false);

        foreach (var type in validatorTypes)
        {
            var modelType = type!.BaseType!.GenericTypeArguments.First();
            var basicValidatorType = typeof(IValidator<>).MakeGenericType(modelType);
            var resultingType = typeof(IOcpiValidator<>).MakeGenericType(modelType);

            services.AddActionValidator(type, sp => sp.GetRequiredService<OcpiValidationContext>().ActionType);
            services.AddScoped(resultingType, sp => sp.GetRequiredService(basicValidatorType));
        }

        return services;
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
