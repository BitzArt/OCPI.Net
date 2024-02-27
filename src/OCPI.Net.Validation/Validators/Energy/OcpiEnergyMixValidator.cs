using FluentValidation;

namespace OCPI.Contracts;

internal class OcpiEnergyMixValidator : OcpiValidator<OcpiEnergyMix>
{
    public OcpiEnergyMixValidator(
        IOcpiValidator<OcpiEnergySource> energySourceValidator,
        IOcpiValidator<OcpiEnvironmentalImpact> environmentalImpactValidator)
    {
        RuleFor(x => x.IsGreenEnergy)
            .NotEmpty();

        RuleForEach(x => x.EnergySources)
            .SetValidator(energySourceValidator);

        RuleForEach(x => x.EnvironmentalImpact)
            .SetValidator(environmentalImpactValidator);

        RuleFor(x => x.SupplierName)
            .MaximumLength(64);

        RuleFor(x => x.EnergyProductName)
            .MaximumLength(64);
    }
}
