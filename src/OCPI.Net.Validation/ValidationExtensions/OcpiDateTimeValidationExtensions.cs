using FluentValidation;

namespace OCPI.Validation;

public static class OcpiDateTimeValidationExtensions
{
    public static IRuleBuilderOptions<TClass, DateTime?> MustValidDateTime<TClass>(this IRuleBuilder<TClass, DateTime?> ruleBuilder) =>
        ruleBuilder.Must(ValidDateTime)
        .WithMessage($"'{{PropertyName}}' is not a valid DateTime. Year must be between {_dateTimeYearLowerBound} and {_dateTimeYearUpperBound}");

    private const int _dateTimeYearLowerBound = 2000;
    private const int _dateTimeYearUpperBound = 2100;

    private static readonly DateTime _validDateTimeMin = new(_dateTimeYearLowerBound, 01, 01);
    private static readonly DateTime _validDateTimeMax = new(_dateTimeYearUpperBound, 01, 01);

    public static bool ValidDateTime(DateTime? value) =>
        value is null || (value > _validDateTimeMin && value < _validDateTimeMax);
}
