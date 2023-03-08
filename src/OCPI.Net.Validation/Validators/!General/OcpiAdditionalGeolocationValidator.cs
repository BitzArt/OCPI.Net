using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiAdditionalGeolocationValidator : HttpValidator<OcpiAdditionalGeolocation>
{
    public OcpiAdditionalGeolocationValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.Latitude)
            .NotEmpty()
            .ValidLatitude();

        JsonRuleFor(x => x.Longitude)
            .NotEmpty()
            .ValidLongitude();

        JsonRuleFor(x => x.Name!)
            .SetValidator(new OcpiDisplayTextValidator(httpMethod))
            .When(x => x.Name is not null);
    }
}
