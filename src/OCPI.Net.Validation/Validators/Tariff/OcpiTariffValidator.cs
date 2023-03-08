using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

public class OcpiTariffValidator : HttpValidator<OcpiTariff>
{
    public OcpiTariffValidator(string httpMethod) : base(httpMethod)
    {
        Unless(HttpMethod.Patch, () =>
        {
            JsonRuleFor(x => x.CountryCode).NotEmpty();
            JsonRuleFor(x => x.PartyId).NotEmpty();
            JsonRuleFor(x => x.Id).NotEmpty();
            JsonRuleFor(x => x.Currency).NotEmpty();
            JsonRuleFor(x => x.Elements).NotEmpty();
            JsonRuleFor(x => x.LastUpdated).NotEmpty();
        });

        JsonRuleFor(x => x.CountryCode)
            .MustValidEnum();

        JsonRuleFor(x => x.PartyId)
            .MaximumLength(3);

        JsonRuleFor(x => x.Id)
            .MaximumLength(36);

        JsonRuleFor(x => x.Currency)
            .MaximumLength(3);

        JsonRuleFor(x => x.Type)
            .MustValidEnum();

        RuleForEach(x => x.TariffAltText)
            .SetValidator(new OcpiDisplayTextValidator(httpMethod));

        JsonRuleFor(x => x.TariffAltUrl)
            .MustValidUrl();

        JsonRuleFor(x => x.MinPrice!)
            .SetValidator(new OcpiPriceValidator(httpMethod));

        JsonRuleFor(x => x.MaxPrice!)
            .SetValidator(new OcpiPriceValidator(httpMethod));

        RuleForEach(x => x.Elements)
            .SetValidator(new OcpiTariffElementValidator(httpMethod));

        JsonRuleFor(x => x.StartDateTime)
            .MustValidDateTime();

        JsonRuleFor(x => x.EndDateTime)
            .MustValidDateTime();

        JsonRuleFor(x => x.EnergyMix!)
            .SetValidator(new OcpiEnergyMixValidator(httpMethod));

        JsonRuleFor(x => x.LastUpdated)
            .MustValidDateTime();
    }
}
