using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiGeolocationValidator : HttpValidator<OcpiGeolocation>
{
    public OcpiGeolocationValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.Latitude)
            .NotEmpty()
            .ValidLatitude();

        JsonRuleFor(x => x.Longitude)
            .NotEmpty()
            .ValidLongitude();
    }
}
