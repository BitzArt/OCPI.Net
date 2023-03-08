using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiBusinessDetailsValidator : HttpValidator<OcpiBusinessDetails>
{
    public OcpiBusinessDetailsValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);

        JsonRuleFor(x => x.Website)
            .ValidUrl();

        JsonRuleFor(x => x.Logo!)
            .SetValidator(new OcpiImageValidator(httpMethod));
    }
}
