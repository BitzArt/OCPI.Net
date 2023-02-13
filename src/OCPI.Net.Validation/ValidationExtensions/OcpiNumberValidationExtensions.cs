using FluentValidation;

namespace OCPI.Validation;

public static class OcpiNumberValidationExtensions
{
    public static IRuleBuilderOptions<TClass, TNumber?> MustMaxDecimalDigits<TClass, TNumber>(this IRuleBuilder<TClass, TNumber?> ruleBuilder, int maxLength)
        where TNumber : struct =>
        ruleBuilder.Must(x => MaxDecimalDigits(x, maxLength)).WithMessage($"'{{PropertyName}}' must not contain more than {maxLength} decimal digits");

    public static bool MaxDecimalDigits<TNumber>(TNumber? value, int? maxLength)
        where TNumber : struct =>
        value is null || value.ToString()!.Length <= maxLength;
}
