using FluentValidation;

namespace OCPI.Contracts;

internal partial class OcpiHoursValidator : ActionValidator<OcpiHours>
{
    public OcpiHoursValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.TwentyFourSeven)
            .NotEmpty();

        RuleForEach(x => x.RegularHours)
            .SetValidator(new OcpiRegularHoursValidator(actionType));

        RuleForEach(x => x.ExceptionalOpenings)
            .SetValidator(new OcpiExceptionalPeriodValidator(actionType));

        RuleForEach(x => x.ExceptionalClosings)
            .SetValidator(new OcpiExceptionalPeriodValidator(actionType));
    }
}
