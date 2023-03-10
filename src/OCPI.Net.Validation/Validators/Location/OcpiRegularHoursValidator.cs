using FluentValidation;
using System.Text.RegularExpressions;

namespace OCPI.Contracts;

internal partial class OcpiRegularHoursValidator : ActionValidator<OcpiRegularHours>
{
    private const string _timePeriodRegexValue = "([0-1][0-9]|2[0-3]):[0-5][0-9]";

    [GeneratedRegex(_timePeriodRegexValue)]
    private static partial Regex TimePeriodRegex();

    public OcpiRegularHoursValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.Weekday)
            .NotEmpty()
            .Must(x => x >= 1 && x <= 7).WithMessage("{PropertyName} must be between 1 and 7");

        JsonRuleFor(x => x.PeriodBegin)
            .NotEmpty()
            .MaximumLength(5)
            .Must(x => TimePeriodRegex().IsMatch(x)).WithMessage($"{{PropertyName}} is not a valid regular period. Regex: {_timePeriodRegexValue}");

        JsonRuleFor(x => x.PeriodEnd)
            .NotEmpty()
            .MaximumLength(5)
            .Must(x => TimePeriodRegex().IsMatch(x)).WithMessage($"{{PropertyName}} is not a valid regular period. Regex: {_timePeriodRegexValue}");
    }
}
