using FluentValidation;

namespace OCPI.Contracts;

internal class OcpiEnergyMixValidator : ActionValidator<OcpiEnergyMix>
{
    public OcpiEnergyMixValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.IsGreenEnergy)
            .NotEmpty();

        RuleForEach(x => x.EnergySources)
            .SetValidator(new OcpiEnergySourceValidator(actionType));

        RuleForEach(x => x.EnvironmentalImpact)
            .SetValidator(new OcpiEnvironmentalImpactValidator(actionType));

        JsonRuleFor(x => x.SupplierName)
            .MaximumLength(64);

        JsonRuleFor(x => x.EnergyProductName)
            .MaximumLength(64);
    }
}
