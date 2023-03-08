using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEnvironmentalImpactValidator : HttpValidator<OcpiEnvironmentalImpact>
{
    public OcpiEnvironmentalImpactValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.Category)
            .NotEmpty()
            .MustValidEnum();

        JsonRuleFor(x => x.Amount)
            .NotEmpty()
            .MustMaxSymbols(10);
    }
}
