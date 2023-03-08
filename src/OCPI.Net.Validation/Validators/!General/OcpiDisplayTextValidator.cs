using FluentValidation;

namespace OCPI.Contracts;

internal class OcpiDisplayTextValidator : HttpValidator<OcpiDisplayText>
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
