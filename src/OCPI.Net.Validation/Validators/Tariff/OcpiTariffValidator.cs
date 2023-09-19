using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiTariffValidator : OcpiValidator<OcpiTariff>
{
    public OcpiTariffValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        Unless(ActionType.Patch, () =>
        {
            JsonRuleFor(x => x.CountryCode).NotEmpty();
            JsonRuleFor(x => x.PartyId).NotEmpty();
            JsonRuleFor(x => x.Id).NotEmpty();
            JsonRuleFor(x => x.Currency).NotEmpty();
            JsonRuleFor(x => x.Elements).NotEmpty();
            JsonRuleFor(x => x.LastUpdated).NotEmpty();
        });

        JsonRuleFor(x => x.CountryCode)
            .ValidEnum();

        JsonRuleFor(x => x.PartyId)
            .MaximumLength(3);

        JsonRuleFor(x => x.Id)
            .MaximumLength(36);

        JsonRuleFor(x => x.Currency)
            .ValidEnum();

        JsonRuleFor(x => x.Type)
            .ValidEnum();

        RuleForEach(x => x.TariffAltText)
            .SetValidator(new OcpiDisplayTextValidator(actionType, ocpiVersion));

        JsonRuleFor(x => x.TariffAltUrl)
            .ValidUrl();

        JsonRuleFor(x => x.MinPrice!)
            .SetValidator(new OcpiPriceValidator(actionType, ocpiVersion));

        JsonRuleFor(x => x.MaxPrice!)
            .SetValidator(new OcpiPriceValidator(actionType, ocpiVersion));

        RuleForEach(x => x.Elements)
            .SetValidator(new OcpiTariffElementValidator(actionType, ocpiVersion));

        JsonRuleFor(x => x.StartDateTime)
            .ValidDateTime();

        JsonRuleFor(x => x.EndDateTime)
            .ValidDateTime();

        JsonRuleFor(x => x.EnergyMix!)
            .SetValidator(new OcpiEnergyMixValidator(actionType, ocpiVersion));

        JsonRuleFor(x => x.LastUpdated)
            .ValidDateTime();
    }
}
