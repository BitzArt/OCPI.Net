using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiGeolocationValidator : ActionValidator<OcpiGeolocation>
{
    public OcpiGeolocationValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.Latitude)
            .NotEmpty()
            .ValidLatitude();

        JsonRuleFor(x => x.Longitude)
            .NotEmpty()
            .ValidLongitude();
    }
}
