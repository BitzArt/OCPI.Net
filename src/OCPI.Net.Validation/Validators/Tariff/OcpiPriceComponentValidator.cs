using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

public class OcpiPriceComponentValidator : HttpValidator<OcpiPriceComponent>
{
    public OcpiPriceComponentValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.Type)
            .NotEmpty()
            .ValidEnum();

        JsonRuleFor(x => x.Price)
            .NotEmpty();
    }
}
