using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

public class OcpiPriceComponentValidator : ActionValidator<OcpiPriceComponent>
{
    public OcpiPriceComponentValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.Type)
            .NotEmpty()
            .ValidEnum();

        JsonRuleFor(x => x.Price)
            .NotEmpty();
    }
}
