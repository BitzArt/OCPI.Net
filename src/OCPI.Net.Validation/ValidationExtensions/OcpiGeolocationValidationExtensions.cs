using FluentValidation;
using System.Text.RegularExpressions;

namespace OCPI.Validation;

public static partial class OcpiGeolocationValidationExtensions
{
    private const string _latitudeRegexValue = "-?[0-9]{1,2}\\.[0-9]{5,7}";
    private const string _longitudeRegexValue = "-?[0-9]{1,3}\\.[0-9]{5,7}";

    [GeneratedRegex(_latitudeRegexValue)]
    private static partial Regex LatitudeRegex();

    [GeneratedRegex(_longitudeRegexValue)]
    private static partial Regex LongitudeRegex();

    // OCPI has an error in documentation. It says the max length for Latitude is 10 but their regex says it is 11.
    public static IRuleBuilderOptions<TClass, string?> ValidLatitude<TClass>(this IRuleBuilder<TClass, string?> ruleBuilder) =>
        ruleBuilder
        .Must(ValidLatitude)
        .WithMessage($"'{{PropertyName}}' is not a valid latitude value. Must match Regex : {_latitudeRegexValue}")
        .MaximumLength(11);

    public static bool ValidLatitude(string? value) =>
        string.IsNullOrEmpty(value) || LatitudeRegex().IsMatch(value!);

    // OCPI has an error in documentation. It says the max length for Longitude is 11 but their regex says it is 12.
    public static IRuleBuilderOptions<TClass, string?> ValidLongitude<TClass>(this IRuleBuilder<TClass, string?> ruleBuilder) =>
        ruleBuilder
        .Must(ValidLongitude)
        .WithMessage($"'{{PropertyName}}' is not a valid longitude value. Must match Regex : {_longitudeRegexValue}")
        .MaximumLength(12);

    public static bool ValidLongitude(string? value) =>
        string.IsNullOrEmpty(value) || LongitudeRegex().IsMatch(value!);
}
