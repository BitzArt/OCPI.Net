using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiStatusScheduleValidator : OcpiValidator<OcpiStatusSchedule>
{
    public OcpiStatusScheduleValidator(OcpiValidationContext validationContext) : base(validationContext)
    {
        RuleFor(x => x.PeriodBegin)
            .NotEmpty()
            .ValidDateTime();

        RuleFor(x => x.PeriodEnd)
            .ValidDateTime();

        RuleFor(x => x.Status)
            .NotEmpty()
            .IsInEnum();
    }
}
