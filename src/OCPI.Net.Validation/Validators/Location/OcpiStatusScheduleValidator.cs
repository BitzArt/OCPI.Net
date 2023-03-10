using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiStatusScheduleValidator : ActionValidator<OcpiStatusSchedule>
{
    public OcpiStatusScheduleValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.PeriodBegin)
            .NotEmpty()
            .ValidDateTime();

        JsonRuleFor(x => x.PeriodEnd)
            .ValidDateTime();

        JsonRuleFor(x => x.Status)
            .NotEmpty()
            .ValidEnum();
    }
}
