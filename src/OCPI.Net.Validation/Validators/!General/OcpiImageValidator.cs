using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiImageValidator : HttpValidator<OcpiImage>
{
    public OcpiImageValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.Url)
            .NotEmpty()
            .MustValidUrl();

        JsonRuleFor(x => x.Thumbnail)
            .MustValidUrl();

        JsonRuleFor(x => x.Category)
            .NotEmpty()
            .MustValidEnum();

        JsonRuleFor(x => x.Type)
            .NotEmpty()
            .MaximumLength(4);

        JsonRuleFor(x => x.Width)
            .MustMaxSymbols(6);

        JsonRuleFor(x => x.Height)
            .MustMaxSymbols(6);
    }
}
