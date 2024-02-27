using FluentValidation;

namespace OCPI.Contracts;

internal class OcpiTariffElementValidator : OcpiValidator<OcpiTariffElement>
{
    public OcpiTariffElementValidator(
        IOcpiValidator<OcpiPriceComponent> priceComponentValidator,
        IOcpiValidator<OcpiTariffRestrictions> tariffRestrictionsValidator)
    {
        RuleFor(x => x.PriceComponents)
            .NotEmpty();

        RuleForEach(x => x.PriceComponents)
            .SetValidator(priceComponentValidator);

        RuleFor(x => x.Restrictions!)
            .SetValidator(tariffRestrictionsValidator);
    }
}
