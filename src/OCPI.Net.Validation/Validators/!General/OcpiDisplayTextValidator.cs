using FluentValidation;

namespace OCPI.Contracts;

internal class OcpiDisplayTextValidator : OcpiValidator<OcpiDisplayText>
{
    public OcpiDisplayTextValidator()
    {
        RuleFor(x => x.Language)
            .NotEmpty()
            .MaximumLength(2);

        RuleFor(x => x.Text)
            .NotEmpty()
            .MaximumLength(512);
    }
}
