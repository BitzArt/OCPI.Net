using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiAdditionalGeolocationValidator : OcpiValidator<OcpiAdditionalGeolocation>
{
    public OcpiAdditionalGeolocationValidator(
        IOcpiValidator<OcpiDisplayText> displayTextValidator)
    {
        RuleFor(x => x.Latitude)
            .NotEmpty()
            .ValidLatitude();

        RuleFor(x => x.Longitude)
            .NotEmpty()
            .ValidLongitude();

        RuleFor(x => x.Name!)
            .SetValidator(displayTextValidator)
            .When(x => x.Name is not null);
    }
}
