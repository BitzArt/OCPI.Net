using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

public class OcpiPriceComponentValidator : HttpValidator<OcpiPriceComponent>
{
    public OcpiPriceComponentValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.Type)
            .NotEmpty()
            .MustValidEnum();

        JsonRuleFor(x => x.Price)
            .NotEmpty()
            .MustMaxSymbols(10);

        JsonRuleFor(x => x.Vat)
            .MustMaxSymbols(5);

        JsonRuleFor(x => x.StepSize)
            .MustMaxSymbols(3);
    }
}
