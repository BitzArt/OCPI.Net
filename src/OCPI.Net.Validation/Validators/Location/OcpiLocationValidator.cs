using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiLocationValidator : OcpiValidator<OcpiLocation>
{
    public OcpiLocationValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
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
            .SetValidator(new OcpiPublishTokenTypeValidator(actionType, ocpiVersion));

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
            .SetValidator(new OcpiGeolocationValidator(actionType, ocpiVersion));

        RuleForEach(x => x.RelatedLocations)
            .SetValidator(new OcpiAdditionalGeolocationValidator(actionType, ocpiVersion));

        // TODO: Specific to OCPI 2.1.1
        //JsonRuleFor(x => x.Type)
        //    .ValidEnum();

        JsonRuleFor(x => x.ParkingType)
            .ValidEnum();

        RuleForEach(x => x.Evses)
            .SetValidator(new OcpiEvseValidator(actionType, ocpiVersion));

        RuleForEach(x => x.Directions)
            .SetValidator(new OcpiDisplayTextValidator(actionType, ocpiVersion));

        JsonRuleFor(x => x.Operator!)
            .SetValidator(new OcpiBusinessDetailsValidator(actionType, ocpiVersion));

        JsonRuleFor(x => x.Suboperator!)
            .SetValidator(new OcpiBusinessDetailsValidator(actionType, ocpiVersion));

        JsonRuleFor(x => x.Owner!)
            .SetValidator(new OcpiBusinessDetailsValidator(actionType, ocpiVersion));

        RuleForEach(x => x.Facilities)
            .ValidEnum();

        JsonRuleFor(x => x.TimeZone)
            .MaximumLength(255);

        JsonRuleFor(x => x.OpeningTimes!)
            .SetValidator(new OcpiHoursValidator(actionType, ocpiVersion));

        RuleForEach(x => x.Images)
            .SetValidator(new OcpiImageValidator(actionType, ocpiVersion));

        JsonRuleFor(x => x.EnergyMix!)
            .SetValidator(new OcpiEnergyMixValidator(actionType, ocpiVersion));

        JsonRuleFor(x => x.LastUpdated)
            .NotEmpty()
            .ValidDateTime();
    }
}
