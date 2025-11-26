using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEnvironmentalImpactValidator : OcpiValidator<OcpiEnvironmentalImpact>
{
    public OcpiEnvironmentalImpactValidator(OcpiValidationContext validationContext) : base(validationContext)
    {
        RuleFor(x => x.Category)
            .NotEmpty()
            .IsInEnum();

        RuleFor(x => x.Amount)
            .NotEmpty()
            .MaxSymbols(10);
    }
}
