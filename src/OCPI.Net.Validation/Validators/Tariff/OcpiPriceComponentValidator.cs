using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiPriceComponentValidator : OcpiValidator<OcpiPriceComponent>
{
    public OcpiPriceComponentValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.Type)
            .NotEmpty()
            .ValidEnum();

        JsonRuleFor(x => x.Price)
            .NotEmpty();
    }
}
