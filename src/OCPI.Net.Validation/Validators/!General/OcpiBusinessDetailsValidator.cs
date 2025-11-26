using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiBusinessDetailsValidator : OcpiValidator<OcpiBusinessDetails>
{
    public OcpiBusinessDetailsValidator(
        OcpiValidationContext validationContext,
        IOcpiValidator<OcpiImage> imageValidator)
        :base(validationContext)
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.Website)
            .ValidUrl();

        RuleFor(x => x.Logo!)
            .SetValidator(imageValidator);
    }
}
