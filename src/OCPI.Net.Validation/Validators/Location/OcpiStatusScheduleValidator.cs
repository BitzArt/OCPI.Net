using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiStatusScheduleValidator : OcpiValidator<OcpiStatusSchedule>
{
    public OcpiStatusScheduleValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.PeriodBegin)
            .NotEmpty()
            .ValidDateTime();

        JsonRuleFor(x => x.PeriodEnd)
            .ValidDateTime();

        JsonRuleFor(x => x.Status)
            .NotEmpty()
            .IsInEnum();
    }
}
