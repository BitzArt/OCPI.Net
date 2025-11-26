using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiPublishTokenTypeValidator : OcpiValidator<OcpiPublishTokenType>
{
    public OcpiPublishTokenTypeValidator(OcpiValidationContext validationContext) : base(validationContext)
    {
        RuleFor(x => x.Uid)
            .MaximumLength(36);

        RuleFor(x => x.Type)
            .IsInEnum();

        RuleFor(x => x.VisualNumber)
            .MaximumLength(64);

        RuleFor(x => x.Issuer)
            .MaximumLength(64);

        RuleFor(x => x.GroupId)
            .MaximumLength(36);
    }
}
