using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiPriceComponentValidator : OcpiValidator<OcpiPriceComponent>
{
    public OcpiPriceComponentValidator()
    {
        RuleFor(x => x.Type)
            .NotEmpty()
            .IsInEnum();

        RuleFor(x => x.Price)
            .NotEmpty();
    }
}
