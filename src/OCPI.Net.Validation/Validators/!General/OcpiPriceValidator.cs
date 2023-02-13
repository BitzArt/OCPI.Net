using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiPriceValidator : OcpiValidator<OcpiPrice>
{
    public OcpiPriceValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.VatExcluded)
            .NotEmpty()
            .MustMaxDecimalDigits(4);

        JsonRuleFor(x => x.VatIncluded)
            .MustMaxDecimalDigits(4);

        JsonRuleFor(x => x.VatIncluded)
            .Must((price, x) => x > price.VatExcluded)
            .When(x => x.VatIncluded is not null && x.VatExcluded is not null)
            .WithMessage("incl_vat cannot be less than excl_vat");
    }
}
