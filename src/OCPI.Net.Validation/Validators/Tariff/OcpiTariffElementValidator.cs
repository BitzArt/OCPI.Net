using FluentValidation;

namespace OCPI.Contracts;

internal class OcpiTariffElementValidator : OcpiValidator<OcpiTariffElement>
{
    public OcpiTariffElementValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.PriceComponents)
            .NotEmpty();

        RuleForEach(x => x.PriceComponents)
            .SetValidator(new OcpiPriceComponentValidator(actionType, ocpiVersion));

        JsonRuleFor(x => x.Restrictions!)
            .SetValidator(new OcpiTariffRestrictionValidator(actionType, ocpiVersion));
    }
}
