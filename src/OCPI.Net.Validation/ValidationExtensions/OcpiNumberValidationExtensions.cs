using FluentValidation;

namespace OCPI.Validation;

public static class OcpiNumberValidationExtensions
{
    public static IRuleBuilderOptions<TClass, TNumber?> MaxSymbols<TClass, TNumber>(this IRuleBuilder<TClass, TNumber?> ruleBuilder, int maxLength)
        where TNumber : struct =>
        ruleBuilder.Must(x => MaxSymbols(x, maxLength)).WithMessage($"'{{PropertyName}}' must not consist of more than {maxLength} symbols");

    public static bool MaxSymbols<TNumber>(TNumber? value, int? maxLength)
        where TNumber : struct =>
        value is null || value.ToString()!.Length <= maxLength;
}
