using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiLocationValidator : OcpiValidator<OcpiLocation>
{
    public OcpiLocationValidator(
        OcpiValidationContext validationContext,
        IOcpiValidator<OcpiPublishTokenType> publishTokenTypeValidator,
        IOcpiValidator<OcpiGeolocation> geolocationValidator,
        IOcpiValidator<OcpiAdditionalGeolocation> additionalGeolocationValidator,
        IOcpiValidator<OcpiEvse> evseValidator,
        IOcpiValidator<OcpiDisplayText> displayTextValidator,
        IOcpiValidator<OcpiBusinessDetails> businessDetailsValidator,
        IOcpiValidator<OcpiHours> hoursValidator,
        IOcpiValidator<OcpiImage> imageValidator,
        IOcpiValidator<OcpiEnergyMix> energyMixValidator)
        : base(validationContext)
    {
        Unless(ActionType.Patch, () =>
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Address).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.Country).NotEmpty();
            RuleFor(x => x.Coordinates).NotEmpty();

            WhenOcpiVersionAbove("2.2", () =>
            {
                RuleFor(x => x.CountryCode).NotEmpty();
                RuleFor(x => x.PartyId).NotEmpty();
                RuleFor(x => x.Publish).NotEmpty();
                RuleFor(x => x.TimeZone).NotEmpty();
            });

            WhenOcpiVersionBelow("2.2", () =>
            {
                RuleFor(x => x.Type).NotEmpty();
                RuleFor(x => x.PostalCode).NotEmpty();
            });
        });

        RuleFor(x => x.CountryCode)
            .IsInEnum();

        RuleFor(x => x.PartyId)
            .MaximumLength(3);

        RuleForEach(x => x.PublishAllowedTo)
            .SetValidator(publishTokenTypeValidator);

        RuleFor(x => x.Name)
            .MaximumLength(255);

        RuleFor(x => x.Address)
            .MaximumLength(45);

        RuleFor(x => x.City)
            .MaximumLength(45);

        RuleFor(x => x.PostalCode)
            .MaximumLength(10);

        RuleFor(x => x.State)
            .MaximumLength(20);

        RuleFor(x => x.Country)
            .MaximumLength(3);

        RuleFor(x => x.Coordinates!)
            .SetValidator(geolocationValidator);

        RuleForEach(x => x.RelatedLocations)
            .SetValidator(additionalGeolocationValidator);

        RuleFor(x => x.ParkingType)
            .IsInEnum();

        RuleForEach(x => x.Evses)
            .SetValidator(evseValidator);

        RuleForEach(x => x.Directions)
            .SetValidator(displayTextValidator);

        RuleFor(x => x.Operator!)
            .SetValidator(businessDetailsValidator);

        RuleFor(x => x.Suboperator!)
            .SetValidator(businessDetailsValidator);

        RuleFor(x => x.Owner!)
            .SetValidator(businessDetailsValidator);

        RuleForEach(x => x.Facilities)
            .IsInEnum();

        RuleFor(x => x.TimeZone)
            .MaximumLength(255);

        RuleFor(x => x.OpeningTimes!)
            .SetValidator(hoursValidator);

        RuleForEach(x => x.Images)
            .SetValidator(imageValidator);

        RuleFor(x => x.EnergyMix!)
            .SetValidator(energyMixValidator);

        RuleFor(x => x.LastUpdated)
            .NotEmpty()
            .ValidDateTime();

        WhenOcpiVersionAbove("2.2", () =>
        {
            RuleFor(x => x.Id)
            .MaximumLength(36);
        });

        WhenOcpiVersionBelow("2.2", () =>
        {
            RuleFor(x => x.Id)
            .MaximumLength(39);

            RuleFor(x => x.Type)
            .IsInEnum();
        });
    }
}
