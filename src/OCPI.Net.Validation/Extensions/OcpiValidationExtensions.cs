using FluentValidation;

namespace OCPI.Validation;

public static class OcpiValidationExtensions
{
    public static IRuleBuilderOptions<TClass, string?> MustNoWhitespace<TClass>(this IRuleBuilder<TClass, string?> ruleBuilder) =>
        ruleBuilder.Must(x => NoWhitespace(x!)).WithMessage("'{PropertyName}' should not contain whitespaces.");

    public static bool NoWhitespace(string value) =>
        string.IsNullOrEmpty(value) || !value.Contains(' ');

    public static IRuleBuilderOptions<TClass, string?> MustInUnicodeRange<TClass>(this IRuleBuilder<TClass, string?> ruleBuilder, int min, int max) =>
        ruleBuilder.Must(x => InUnicodeRange(x!, min, max)).WithMessage($"'{{PropertyName}}' is not in unicode range U+{min:x4} : U+{max:x4}.");

    public static bool InUnicodeRange(string value, int min, int max) =>
        string.IsNullOrEmpty(value) || value.All(x => x >= min && x <= max);

    public static IRuleBuilderOptions<TClass, string?> MustValidUrl<TClass>(this IRuleBuilder<TClass, string?> ruleBuilder) =>
        ruleBuilder.Must(x => ValidUrl(x!)).WithMessage($"'{{PropertyName}}' is not a valid url.");

    public static bool ValidUrl(string value) =>
        string.IsNullOrEmpty(value) || (Uri.IsWellFormedUriString(value, UriKind.Absolute) && value.Length < 2048);

    public static IRuleBuilderOptions<TClass, TEnum?> MustValidEnum<TClass, TEnum>(this IRuleBuilder<TClass, TEnum?> ruleBuilder)
        where TEnum : struct, Enum =>
        ruleBuilder.Must(x => ValidEnum(x!)).WithMessage($"'{{PropertyName}}' is not of a valid value.");

    public static bool ValidEnum<TEnum>(TEnum? value)
        where TEnum : struct, Enum =>
        value is null || Enum.IsDefined(value!.Value);

    public static IRuleBuilderOptions<TClass, TNumber?> MustMaxDecimalDigits<TClass, TNumber>(this IRuleBuilder<TClass, TNumber?> ruleBuilder, int maxLength) =>
        ruleBuilder.Must(x => MaxDecimalDigits(x!, maxLength)).WithMessage($"'{{PropertyName}}' must not be longer than {maxLength} digits");

    public static bool MaxDecimalDigits<TNumber>(TNumber? value, int maxLength) =>
        value is null || value.ToString()!.Length <= maxLength;
}
