using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEnergySourceValidator : OcpiValidator<OcpiEnergySource>
{
    public OcpiEnergySourceValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.Source)
            .NotEmpty()
            .ValidEnum();

        JsonRuleFor(x => x.Percentage)
            .NotEmpty()
            .Must(x => x!.Value >= 0 && x!.Value <= 100);
    }
}
