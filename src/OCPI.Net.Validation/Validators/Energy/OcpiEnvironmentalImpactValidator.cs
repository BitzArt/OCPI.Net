using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEnvironmentalImpactValidator : OcpiValidator<OcpiEnvironmentalImpact>
{
    public OcpiEnvironmentalImpactValidator()
    {
        RuleFor(x => x.Category)
            .NotEmpty()
            .IsInEnum();

        RuleFor(x => x.Amount)
            .NotEmpty()
            .MaxSymbols(10);
    }
}
