using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEvseValidator : ActionValidator<OcpiEvse>
{
    public OcpiEvseValidator(ActionType actionType) : base(actionType)
    {
        Unless(ActionType.Patch, () =>
        {
            JsonRuleFor(x => x.Uid).NotEmpty();
            JsonRuleFor(x => x.Status).NotEmpty();

            JsonRuleFor(x => x.Connectors)
            .NotEmpty();
        });

        JsonRuleFor(x => x.Uid)
            .MaximumLength(36);

        JsonRuleFor(x => x.EvseId)
            .MaximumLength(48);

        JsonRuleFor(x => x.Status)
            .ValidEnum();

        RuleForEach(x => x.StatusSchedule)
            .SetValidator(new OcpiStatusScheduleValidator(actionType));

        RuleForEach(x => x.Capabilities)
            .ValidEnum();

        JsonRuleFor(x => x.FloorLevel)
            .MaximumLength(4);

        JsonRuleFor(x => x.Coordinates!)
            .SetValidator(new OcpiGeolocationValidator(actionType));

        JsonRuleFor(x => x.PhysicalReference);

        RuleForEach(x => x.Directions)
            .SetValidator(new OcpiDisplayTextValidator(actionType));

        RuleForEach(x => x.ParkingRestrictions)
            .ValidEnum();

        RuleForEach(x => x.Images)
            .SetValidator(new OcpiImageValidator(actionType));

        JsonRuleFor(x => x.LastUpdated)
            .NotEmpty()
            .ValidDateTime();
    }
}
