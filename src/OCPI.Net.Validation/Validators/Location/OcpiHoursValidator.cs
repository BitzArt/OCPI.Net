using FluentValidation;

namespace OCPI.Contracts;

internal partial class OcpiHoursValidator : OcpiValidator<OcpiHours>
{
    public OcpiHoursValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.TwentyFourSeven)
            .NotEmpty();

        RuleForEach(x => x.RegularHours)
            .SetValidator(new OcpiRegularHoursValidator(actionType, ocpiVersion));

        RuleForEach(x => x.ExceptionalOpenings)
            .SetValidator(new OcpiExceptionalPeriodValidator(actionType, ocpiVersion));

        RuleForEach(x => x.ExceptionalClosings)
            .SetValidator(new OcpiExceptionalPeriodValidator(actionType, ocpiVersion));
    }
}
