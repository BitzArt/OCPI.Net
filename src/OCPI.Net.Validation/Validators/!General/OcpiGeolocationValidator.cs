using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiGeolocationValidator : OcpiValidator<OcpiGeolocation>
{
    public OcpiGeolocationValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.Latitude)
            .NotEmpty()
            .ValidLatitude();

        JsonRuleFor(x => x.Longitude)
            .NotEmpty()
            .ValidLongitude();
    }
}
