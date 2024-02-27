using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEnergySourceValidator : OcpiValidator<OcpiEnergySource>
{
    public OcpiEnergySourceValidator()
    {
        RuleFor(x => x.Source)
            .NotEmpty()
            .IsInEnum();

        RuleFor(x => x.Percentage)
            .NotEmpty()
            .Must(x => x!.Value >= 0 && x!.Value <= 100);
    }
}
