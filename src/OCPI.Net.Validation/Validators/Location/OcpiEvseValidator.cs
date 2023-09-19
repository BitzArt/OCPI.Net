using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEvseValidator : OcpiValidator<OcpiEvse>
{
    public OcpiEvseValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        Unless(ActionType.Patch, () =>
        {
            JsonRuleFor(x => x.Uid).NotEmpty();
            JsonRuleFor(x => x.Status).NotEmpty();

            JsonRuleFor(x => x.Connectors)
            .NotEmpty();
        });

        WhenOcpiVersionAbove("2.2", () =>
        {
            JsonRuleFor(x => x.Uid)
            .MaximumLength(36);
        });

        WhenOcpiVersionBelow("2.2", () =>
        {
            JsonRuleFor(x => x.Uid)
            .MaximumLength(39);
        });

        JsonRuleFor(x => x.EvseId)
            .MaximumLength(48);

        JsonRuleFor(x => x.Status)
            .IsInEnum();

        RuleForEach(x => x.StatusSchedule)
            .SetValidator(new OcpiStatusScheduleValidator(actionType, ocpiVersion));

        RuleForEach(x => x.Capabilities)
            .IsInEnum();

        JsonRuleFor(x => x.FloorLevel)
            .MaximumLength(4);

        JsonRuleFor(x => x.Coordinates!)
            .SetValidator(new OcpiGeolocationValidator(actionType, ocpiVersion));

        JsonRuleFor(x => x.PhysicalReference);

        RuleForEach(x => x.Directions)
            .SetValidator(new OcpiDisplayTextValidator(actionType, ocpiVersion));

        RuleForEach(x => x.ParkingRestrictions)
            .IsInEnum();

        RuleForEach(x => x.Images)
            .SetValidator(new OcpiImageValidator(actionType, ocpiVersion));

        JsonRuleFor(x => x.LastUpdated)
            .NotEmpty()
            .ValidDateTime();
    }
}
