﻿using FluentValidation;

namespace OCPI.Validation;

public static class OcpiStringValidationExtensions
{
    public static IRuleBuilderOptions<TClass, string?> NoWhitespace<TClass>(this IRuleBuilder<TClass, string?> ruleBuilder) =>
        ruleBuilder.Must(NoWhitespace).WithMessage("'{PropertyName}' should not contain whitespaces.");

    public static bool NoWhitespace(string? value) =>
        string.IsNullOrEmpty(value) || !value.Contains(' ');

    public static IRuleBuilderOptions<TClass, string?> InUnicodeRange<TClass>(this IRuleBuilder<TClass, string?> ruleBuilder, int min, int max) =>
        ruleBuilder.Must(x => InUnicodeRange(x, min, max)).WithMessage($"'{{PropertyName}}' is not in unicode range U+{min:x4} : U+{max:x4}.");

    public static bool InUnicodeRange(string? value, int min, int max) =>
        string.IsNullOrEmpty(value) || value.All(x => x >= min && x <= max);

    public static IRuleBuilderOptions<TClass, string?> ValidUrl<TClass>(this IRuleBuilder<TClass, string?> ruleBuilder) =>
        ruleBuilder.Must(ValidUrl).WithMessage($"'{{PropertyName}}' is not a valid url.");

    public static bool ValidUrl(string? value) =>
        string.IsNullOrEmpty(value) || (Uri.IsWellFormedUriString(value, UriKind.Absolute) && value.Length < 2048);
}
