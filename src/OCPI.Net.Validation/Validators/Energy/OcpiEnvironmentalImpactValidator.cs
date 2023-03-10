using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEnvironmentalImpactValidator : ActionValidator<OcpiEnvironmentalImpact>
{
    public OcpiEnvironmentalImpactValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.Category)
            .NotEmpty()
            .ValidEnum();

        JsonRuleFor(x => x.Amount)
            .NotEmpty()
            .MaxSymbols(10);
    }
}
