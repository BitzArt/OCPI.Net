using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using OCPI.Contracts;
using OCPI.Validation;
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
            var resultingType = typeof(IOcpiValidator<>).MakeGenericType(modelType);
            services.AddScoped(type);
            services.AddScoped(resultingType, x =>
            {
                var instance = x.GetRequiredService(type);
                var validationContext = x.GetRequiredService<OcpiValidationContext>();
                (instance as IActionValidator)!.ActionType = validationContext.ActionType;
                (instance as IOcpiValidator)!.OcpiVersion = validationContext.OcpiVersion!.Value;
                return instance!;
            });
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
