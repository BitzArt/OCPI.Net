using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

public class OcpiTariffValidator : ActionValidator<OcpiTariff>
{
    public OcpiTariffValidator(ActionType actionType) : base(actionType)
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
            .SetValidator(new OcpiDisplayTextValidator(actionType));

        JsonRuleFor(x => x.TariffAltUrl)
            .ValidUrl();

        JsonRuleFor(x => x.MinPrice!)
            .SetValidator(new OcpiPriceValidator(actionType));

        JsonRuleFor(x => x.MaxPrice!)
            .SetValidator(new OcpiPriceValidator(actionType));

        RuleForEach(x => x.Elements)
            .SetValidator(new OcpiTariffElementValidator(actionType));

        JsonRuleFor(x => x.StartDateTime)
            .ValidDateTime();

        JsonRuleFor(x => x.EndDateTime)
            .ValidDateTime();

        JsonRuleFor(x => x.EnergyMix!)
            .SetValidator(new OcpiEnergyMixValidator(actionType));

        JsonRuleFor(x => x.LastUpdated)
            .ValidDateTime();
    }
}
