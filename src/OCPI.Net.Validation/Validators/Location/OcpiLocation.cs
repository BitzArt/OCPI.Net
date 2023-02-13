using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiLocationValidator : OcpiValidator<OcpiLocation>
{
    public OcpiLocationValidator(string httpMethod) : base(httpMethod)
    {
        When(x => !IsPatch, () =>
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
            .MustValidEnum();

        JsonRuleFor(x => x.PartyId)
            .MaximumLength(3);

        JsonRuleFor(x => x.Id)
            .MaximumLength(36);

        RuleForEach(x => x.PublishAllowedTo)
            .SetValidator(new OcpiPublishTokenTypeValidator(httpMethod));

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
            .SetValidator(new OcpiGeolocationValidator(httpMethod));

        RuleForEach(x => x.RelatedLocations)
            .SetValidator(new OcpiAdditionalGeolocationValidator(httpMethod));

        JsonRuleFor(x => x.ParkingType)
            .MustValidEnum();

        RuleForEach(x => x.Evses)
            .SetValidator(new OcpiEvseValidator(httpMethod));

        RuleForEach(x => x.Directions)
            .SetValidator(new OcpiDisplayTextValidator(httpMethod));

        JsonRuleFor(x => x.Operator!)
            .SetValidator(new OcpiBusinessDetailsValidator(httpMethod));

        JsonRuleFor(x => x.Suboperator!)
            .SetValidator(new OcpiBusinessDetailsValidator(httpMethod));

        JsonRuleFor(x => x.Owner!)
            .SetValidator(new OcpiBusinessDetailsValidator(httpMethod));

        RuleForEach(x => x.Facilities)
            .MustValidEnum();

        JsonRuleFor(x => x.TimeZone)
            .MaximumLength(255);

        JsonRuleFor(x => x.OpeningTimes!)
            .SetValidator(new OcpiHoursValidator(httpMethod));

        RuleForEach(x => x.Images)
            .SetValidator(new OcpiImageValidator(httpMethod));

        JsonRuleFor(x => x.EnergyMix!)
            .SetValidator(new OcpiEnergyMixValidator(httpMethod));

        JsonRuleFor(x => x.LastUpdated)
            .NotEmpty()
            .MustValidDateTime();
    }
}
