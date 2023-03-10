using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiLocationValidator : ActionValidator<OcpiLocation>
{
    public OcpiLocationValidator(ActionType actionType) : base(actionType)
    {
        Unless(ActionType.Patch, () =>
        {
            JsonRuleFor(x => x.CountryCode).NotEmpty();
            JsonRuleFor(x => x.PartyId).NotEmpty();
            JsonRuleFor(x => x.Id).NotEmpty();
            JsonRuleFor(x => x.Publish).NotEmpty();
            JsonRuleFor(x => x.Address).NotEmpty();
            JsonRuleFor(x => x.City).NotEmpty();
            JsonRuleFor(x => x.Country).NotEmpty();
            JsonRuleFor(x => x.Coordinates).NotEmpty();
            JsonRuleFor(x => x.TimeZone).NotEmpty();
        });

        JsonRuleFor(x => x.CountryCode)
            .ValidEnum();

        JsonRuleFor(x => x.PartyId)
            .MaximumLength(3);

        JsonRuleFor(x => x.Id)
            .MaximumLength(36);

        RuleForEach(x => x.PublishAllowedTo)
            .SetValidator(new OcpiPublishTokenTypeValidator(actionType));

        JsonRuleFor(x => x.Name)
            .MaximumLength(255);

        JsonRuleFor(x => x.Address)
            .MaximumLength(45);

        JsonRuleFor(x => x.City)
            .MaximumLength(45);

        JsonRuleFor(x => x.PostalCode)
            .MaximumLength(10);

        JsonRuleFor(x => x.State)
            .MaximumLength(20);

        JsonRuleFor(x => x.Country)
            .MaximumLength(3);

        JsonRuleFor(x => x.Coordinates!)
            .SetValidator(new OcpiGeolocationValidator(actionType));

        RuleForEach(x => x.RelatedLocations)
            .SetValidator(new OcpiAdditionalGeolocationValidator(actionType));

        JsonRuleFor(x => x.ParkingType)
            .ValidEnum();

        RuleForEach(x => x.Evses)
            .SetValidator(new OcpiEvseValidator(actionType));

        RuleForEach(x => x.Directions)
            .SetValidator(new OcpiDisplayTextValidator(actionType));

        JsonRuleFor(x => x.Operator!)
            .SetValidator(new OcpiBusinessDetailsValidator(actionType));

        JsonRuleFor(x => x.Suboperator!)
            .SetValidator(new OcpiBusinessDetailsValidator(actionType));

        JsonRuleFor(x => x.Owner!)
            .SetValidator(new OcpiBusinessDetailsValidator(actionType));

        RuleForEach(x => x.Facilities)
            .ValidEnum();

        JsonRuleFor(x => x.TimeZone)
            .MaximumLength(255);

        JsonRuleFor(x => x.OpeningTimes!)
            .SetValidator(new OcpiHoursValidator(actionType));

        RuleForEach(x => x.Images)
            .SetValidator(new OcpiImageValidator(actionType));

        JsonRuleFor(x => x.EnergyMix!)
            .SetValidator(new OcpiEnergyMixValidator(actionType));

        JsonRuleFor(x => x.LastUpdated)
            .NotEmpty()
            .ValidDateTime();
    }
}
