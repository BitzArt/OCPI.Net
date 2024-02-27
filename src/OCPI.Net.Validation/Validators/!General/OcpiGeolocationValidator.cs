using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiGeolocationValidator : OcpiValidator<OcpiGeolocation>
{
    public OcpiGeolocationValidator()
    {
        RuleFor(x => x.Latitude)
            .NotEmpty()
            .ValidLatitude();

        RuleFor(x => x.Longitude)
            .NotEmpty()
            .ValidLongitude();
    }
}
