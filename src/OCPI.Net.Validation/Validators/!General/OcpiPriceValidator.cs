using FluentValidation;

namespace OCPI.Contracts;

internal class OcpiPriceValidator : ActionValidator<OcpiPrice>
{
    public OcpiPriceValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.ExclVat)
            .NotEmpty();

        //JsonRuleFor(x => x.InclVat);

        JsonRuleFor(x => x.InclVat)
            .Must((price, x) => x > price.ExclVat)
            .When(x => x.InclVat is not null && x.ExclVat is not null)
            .WithMessage("incl_vat cannot be less than excl_vat");
    }
}
