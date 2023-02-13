using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiDisplayTextValidator : OcpiValidator<OcpiDisplayText>
{
    public OcpiDisplayTextValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.Language)
            .NotEmpty()
            .MaximumLength(2);

        JsonRuleFor(x => x.Text)
            .NotEmpty()
            .MaximumLength(512);
    }
}
