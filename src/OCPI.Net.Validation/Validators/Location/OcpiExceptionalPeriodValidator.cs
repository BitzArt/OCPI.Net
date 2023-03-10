using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiExceptionalPeriodValidator : ActionValidator<OcpiExceptionalPeriod>
{
    public OcpiExceptionalPeriodValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.PeriodBegin)
            .NotEmpty()
            .ValidDateTime();

        JsonRuleFor(x => x.PeriodEnd)
            .NotEmpty()
            .ValidDateTime();
    }
}
