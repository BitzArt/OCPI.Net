using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEnvironmentalImpactValidator : OcpiValidator<OcpiEnvironmentalImpact>
{
    public OcpiEnvironmentalImpactValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.Category)
            .NotEmpty()
            .MustValidEnum();

        JsonRuleFor(x => x.Amount)
            .NotEmpty()
            .MustMaxDecimalDigits(4);
    }
}
