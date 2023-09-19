using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiAdditionalGeolocationValidator : OcpiValidator<OcpiAdditionalGeolocation>
{
    public OcpiAdditionalGeolocationValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.Latitude)
            .NotEmpty()
            .ValidLatitude();

        JsonRuleFor(x => x.Longitude)
            .NotEmpty()
            .ValidLongitude();

        JsonRuleFor(x => x.Name!)
            .SetValidator(new OcpiDisplayTextValidator(actionType, ocpiVersion))
            .When(x => x.Name is not null);
    }
}
