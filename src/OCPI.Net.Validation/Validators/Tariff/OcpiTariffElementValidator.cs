using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiTariffElementValidator : OcpiValidator<OcpiTariffElement>
{
    public OcpiTariffElementValidator(
        OcpiValidationContext validationContext,
        IOcpiValidator<OcpiPriceComponent> priceComponentValidator,
        IOcpiValidator<OcpiTariffRestrictions> tariffRestrictionsValidator)
        : base(validationContext)
    {
        RuleFor(x => x.PriceComponents)
            .NotEmpty();

        RuleForEach(x => x.PriceComponents)
            .SetValidator(priceComponentValidator);

        RuleFor(x => x.Restrictions!)
            .SetValidator(tariffRestrictionsValidator);
    }
}
