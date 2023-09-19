using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiExceptionalPeriodValidator : OcpiValidator<OcpiExceptionalPeriod>
{
    public OcpiExceptionalPeriodValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.PeriodBegin)
            .NotEmpty()
            .ValidDateTime();

        JsonRuleFor(x => x.PeriodEnd)
            .NotEmpty()
            .ValidDateTime();
    }
}
