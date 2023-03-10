using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

public class OcpiTariffRestrictionValidator : ActionValidator<OcpiTariffRestriction>
{
    public OcpiTariffRestrictionValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.StartTime)
            .MaximumLength(5);

        JsonRuleFor(x => x.EndTime)
            .MaximumLength(5);

        JsonRuleFor(x => x.StartDate)
            .MaximumLength(10);

        JsonRuleFor(x => x.EndDate)
            .MaximumLength(10);

        RuleForEach(x => x.DayOfWeek)
            .ValidEnum();

        JsonRuleFor(x => x.Reservation)
            .ValidEnum();
    }
}
