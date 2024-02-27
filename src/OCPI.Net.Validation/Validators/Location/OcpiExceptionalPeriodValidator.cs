using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiExceptionalPeriodValidator : OcpiValidator<OcpiExceptionalPeriod>
{
    public OcpiExceptionalPeriodValidator()
    {
        RuleFor(x => x.PeriodBegin)
            .NotEmpty()
            .ValidDateTime();

        RuleFor(x => x.PeriodEnd)
            .NotEmpty()
            .ValidDateTime();
    }
}
