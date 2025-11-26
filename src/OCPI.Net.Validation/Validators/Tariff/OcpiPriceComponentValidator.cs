using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiPriceComponentValidator : OcpiValidator<OcpiPriceComponent>
{
    public OcpiPriceComponentValidator(OcpiValidationContext validationContext) : base(validationContext)
    {
        RuleFor(x => x.Type)
            .NotEmpty()
            .IsInEnum();

        RuleFor(x => x.Price)
            .NotEmpty();
    }
}
