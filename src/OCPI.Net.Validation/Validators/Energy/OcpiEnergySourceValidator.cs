using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEnergySourceValidator : HttpValidator<OcpiEnergySource>
{
    public OcpiEnergySourceValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.Source)
            .NotEmpty()
            .MustValidEnum();

        JsonRuleFor(x => x.Percentage)
            .NotEmpty()
            .Must(x => x!.Value >= 0 && x!.Value <= 100);
    }
}
