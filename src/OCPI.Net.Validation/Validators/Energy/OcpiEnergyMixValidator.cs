using FluentValidation;
using OCPI.Validation;
using System.Text.Json.Serialization;

namespace OCPI.Contracts;

internal class OcpiEnergyMixValidator : OcpiValidator<OcpiEnergyMix>
{
    public OcpiEnergyMixValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.IsGreenEnergy)
            .NotEmpty();

        RuleForEach(x => x.EnergySources)
            .SetValidator(new OcpiEnergySourceValidator(httpMethod));

        RuleForEach(x => x.EnvironmentalImpact)
            .SetValidator(new OcpiEnvironmentalImpactValidator(httpMethod));

        JsonRuleFor(x => x.SupplierName)
            .MaximumLength(64);

        JsonRuleFor(x => x.EnergyProductName)
            .MaximumLength(64);
    }
}
