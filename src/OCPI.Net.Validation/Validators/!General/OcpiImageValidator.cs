using FluentValidation;
using OCPI.Validation;
using System.Text.Json.Serialization;

namespace OCPI.Contracts;

internal class OcpiImageValidator : OcpiValidator<OcpiImage>
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
            .MustMaxDecimalDigits(5);

        JsonRuleFor(x => x.Height)
            .MustMaxDecimalDigits(5);
    }
}
