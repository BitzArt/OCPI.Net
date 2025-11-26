using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiTariffValidator : OcpiValidator<OcpiTariff>
{
    public OcpiTariffValidator(
        OcpiValidationContext validationContext,
        IOcpiValidator<OcpiDisplayText> displayTextValidator,
        IOcpiValidator<OcpiPrice> priceValidator,
        IOcpiValidator<OcpiTariffElement> tariffElementValidator,
        IOcpiValidator<OcpiEnergyMix> energyMixValidator)
        : base(validationContext)
    {
        Unless(ActionType.Patch, () =>
        {
            RuleFor(x => x.CountryCode).NotEmpty();
            RuleFor(x => x.PartyId).NotEmpty();
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Currency).NotEmpty();
            RuleFor(x => x.Elements).NotEmpty();
            RuleFor(x => x.LastUpdated).NotEmpty();
        });

        RuleFor(x => x.CountryCode)
            .IsInEnum();

        RuleFor(x => x.PartyId)
            .MaximumLength(3);

        RuleFor(x => x.Id)
            .MaximumLength(36);

        RuleFor(x => x.Currency)
            .IsInEnum();

        RuleFor(x => x.Type)
            .IsInEnum();

        RuleForEach(x => x.TariffAltText)
            .SetValidator(displayTextValidator);

        RuleFor(x => x.TariffAltUrl)
            .ValidUrl();

        RuleFor(x => x.MinPrice!)
            .SetValidator(priceValidator);

        RuleFor(x => x.MaxPrice!)
            .SetValidator(priceValidator);

        RuleForEach(x => x.Elements)
            .SetValidator(tariffElementValidator);

        RuleFor(x => x.StartDateTime)
            .ValidDateTime();

        RuleFor(x => x.EndDateTime)
            .ValidDateTime();

        RuleFor(x => x.EnergyMix!)
            .SetValidator(energyMixValidator);

        RuleFor(x => x.LastUpdated)
            .ValidDateTime();
    }
}
