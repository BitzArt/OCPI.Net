using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEnvironmentalImpactValidator : OcpiValidator<OcpiEnvironmentalImpact>
{
    public OcpiEnvironmentalImpactValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.Category)
            .NotEmpty()
            .IsInEnum();

        JsonRuleFor(x => x.Amount)
            .NotEmpty()
            .MaxSymbols(10);
    }
}
