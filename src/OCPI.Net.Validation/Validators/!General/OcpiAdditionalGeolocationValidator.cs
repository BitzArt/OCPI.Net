using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiAdditionalGeolocationValidator : ActionValidator<OcpiAdditionalGeolocation>
{
    public OcpiAdditionalGeolocationValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.Latitude)
            .NotEmpty()
            .ValidLatitude();

        JsonRuleFor(x => x.Longitude)
            .NotEmpty()
            .ValidLongitude();

        JsonRuleFor(x => x.Name!)
            .SetValidator(new OcpiDisplayTextValidator(actionType))
            .When(x => x.Name is not null);
    }
}
