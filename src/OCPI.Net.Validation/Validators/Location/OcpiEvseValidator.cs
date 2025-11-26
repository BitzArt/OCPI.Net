using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEvseValidator : OcpiValidator<OcpiEvse>
{
    public OcpiEvseValidator(
        OcpiValidationContext validationContext,
        IOcpiValidator<OcpiStatusSchedule> statusScheduleValidator,
        IOcpiValidator<OcpiGeolocation> geolocationValidator,
        IOcpiValidator<OcpiDisplayText> displayTextValidator,
        IOcpiValidator<OcpiImage> imageValidator)
        : base(validationContext)
    {
        Unless(ActionType.Patch, () =>
        {
            RuleFor(x => x.Uid).NotEmpty();
            RuleFor(x => x.Status).NotEmpty();

            RuleFor(x => x.Connectors)
            .NotEmpty();
        });

        RuleFor(x => x.EvseId)
            .MaximumLength(48);

        RuleFor(x => x.Status)
            .IsInEnum();

        RuleForEach(x => x.StatusSchedule)
            .SetValidator(statusScheduleValidator);

        RuleForEach(x => x.Capabilities)
            .IsInEnum();

        RuleFor(x => x.FloorLevel)
            .MaximumLength(4);

        RuleFor(x => x.Coordinates!)
            .SetValidator(geolocationValidator);

        RuleFor(x => x.PhysicalReference);

        RuleForEach(x => x.Directions)
            .SetValidator(displayTextValidator);

        RuleForEach(x => x.ParkingRestrictions)
            .IsInEnum();

        RuleForEach(x => x.Images)
            .SetValidator(imageValidator);

        RuleFor(x => x.LastUpdated)
            .NotEmpty()
            .ValidDateTime();

        WhenOcpiVersionAbove("2.2", () =>
        {
            RuleFor(x => x.Uid)
            .MaximumLength(36);
        });

        WhenOcpiVersionBelow("2.2", () =>
        {
            RuleFor(x => x.Uid)
            .MaximumLength(39);
        });
    }
}
