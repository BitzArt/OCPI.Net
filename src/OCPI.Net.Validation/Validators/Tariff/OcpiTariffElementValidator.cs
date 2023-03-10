using FluentValidation;

namespace OCPI.Contracts;

public class OcpiTariffElementValidator : ActionValidator<OcpiTariffElement>
{
    public OcpiTariffElementValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.PriceComponents)
            .NotEmpty();

        RuleForEach(x => x.PriceComponents)
            .SetValidator(new OcpiPriceComponentValidator(actionType));

        RuleForEach(x => x.Restrictions)
            .SetValidator(new OcpiTariffRestrictionValidator(actionType));
    }
}
