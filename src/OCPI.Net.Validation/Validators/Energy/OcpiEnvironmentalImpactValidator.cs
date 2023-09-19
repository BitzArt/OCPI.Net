using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEnvironmentalImpactValidator : OcpiValidator<OcpiEnvironmentalImpact>
{
    public OcpiEnvironmentalImpactValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.Category)
            .NotEmpty()
            .ValidEnum();

        JsonRuleFor(x => x.Amount)
            .NotEmpty()
            .MaxSymbols(10);
    }
}
