using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

public class OcpiTariffElementValidator : HttpValidator<OcpiTariffElement>
{
    public OcpiTariffElementValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.PriceComponents)
            .NotEmpty();

        RuleForEach(x => x.PriceComponents)
            .SetValidator(new OcpiPriceComponentValidator(httpMethod));

        RuleForEach(x => x.Restrictions)
            .SetValidator(new OcpiTariffRestrictionValidator(httpMethod));
    }
}
