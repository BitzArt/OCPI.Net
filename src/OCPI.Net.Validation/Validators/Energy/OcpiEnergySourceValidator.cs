using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEnergySourceValidator : ActionValidator<OcpiEnergySource>
{
    public OcpiEnergySourceValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.Source)
            .NotEmpty()
            .ValidEnum();

        JsonRuleFor(x => x.Percentage)
            .NotEmpty()
            .Must(x => x!.Value >= 0 && x!.Value <= 100);
    }
}
