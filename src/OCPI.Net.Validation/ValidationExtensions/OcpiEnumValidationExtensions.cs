using FluentValidation;

namespace OCPI.Validation;

public static class OcpiEnumValidationExtensions
{
    public static IRuleBuilderOptions<TClass, TEnum> ValidEnum<TClass, TEnum>(this IRuleBuilder<TClass, TEnum> ruleBuilder)
        where TEnum : struct, Enum
        => ValidEnum(ruleBuilder);

    public static IRuleBuilderOptions<TClass, TEnum?> ValidEnum<TClass, TEnum>(this IRuleBuilder<TClass, TEnum?> ruleBuilder)
        where TEnum : struct, Enum =>
        ruleBuilder.Must(ValidEnum).WithMessage($"'{{PropertyName}}' is not of a valid value.");

    public static bool ValidEnum<TEnum>(TEnum? value)
        where TEnum : struct, Enum =>
        value is null || Enum.IsDefined(value!.Value);
}
