using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiGeolocationValidator : OcpiValidator<OcpiGeolocation>
{
    public OcpiGeolocationValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.Latitude)
            .NotEmpty()
            .MustValidLatitude();

        JsonRuleFor(x => x.Longitude)
            .NotEmpty()
            .MustValidLongitude();
    }
}
