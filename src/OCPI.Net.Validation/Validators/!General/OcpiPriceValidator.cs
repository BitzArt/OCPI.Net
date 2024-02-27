using FluentValidation;

namespace OCPI.Contracts;

internal class OcpiPriceValidator : OcpiValidator<OcpiPrice>
{
    public OcpiPriceValidator()
    {
        RuleFor(x => x.ExclVat)
            .NotEmpty();

        //RuleFor(x => x.InclVat);

        RuleFor(x => x.InclVat)
            .Must((price, x) => x > price.ExclVat)
            .When(x => x.InclVat is not null && x.ExclVat is not null)
            .WithMessage("incl_vat cannot be less than excl_vat");
    }
}
