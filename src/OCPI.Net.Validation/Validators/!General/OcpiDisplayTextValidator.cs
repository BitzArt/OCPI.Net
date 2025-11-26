using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiDisplayTextValidator : OcpiValidator<OcpiDisplayText>
{
    public OcpiDisplayTextValidator(OcpiValidationContext validationContext) : base(validationContext)
    {
        RuleFor(x => x.Language)
            .NotEmpty()
            .MaximumLength(2);

        RuleFor(x => x.Text)
            .NotEmpty()
            .MaximumLength(512);
    }
}
