using FluentValidation;

namespace OCPI.Contracts;

internal class OcpiEnergyMixValidator : OcpiValidator<OcpiEnergyMix>
{
    public OcpiEnergyMixValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.IsGreenEnergy)
            .NotEmpty();

        RuleForEach(x => x.EnergySources)
            .SetValidator(new OcpiEnergySourceValidator(actionType, ocpiVersion));

        RuleForEach(x => x.EnvironmentalImpact)
            .SetValidator(new OcpiEnvironmentalImpactValidator(actionType, ocpiVersion));

        JsonRuleFor(x => x.SupplierName)
            .MaximumLength(64);

        JsonRuleFor(x => x.EnergyProductName)
            .MaximumLength(64);
    }
}
