using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiImageValidator : HttpValidator<OcpiImage>
{
    public OcpiImageValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.Url)
            .NotEmpty()
            .ValidUrl();

        JsonRuleFor(x => x.Thumbnail)
            .ValidUrl();

        JsonRuleFor(x => x.Category)
            .NotEmpty()
            .ValidEnum();

        JsonRuleFor(x => x.Type)
            .NotEmpty()
            .MaximumLength(4);

        JsonRuleFor(x => x.Width)
            .MaxSymbols(5);

        JsonRuleFor(x => x.Height)
            .MaxSymbols(5);
    }
}
