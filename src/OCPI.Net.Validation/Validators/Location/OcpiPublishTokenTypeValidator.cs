using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiPublishTokenTypeValidator : OcpiValidator<OcpiPublishTokenType>
{
    public OcpiPublishTokenTypeValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.Uid)
            .MaximumLength(36);

        JsonRuleFor(x => x.Type)
            .IsInEnum();

        JsonRuleFor(x => x.VisualNumber)
            .MaximumLength(64);

        JsonRuleFor(x => x.Issuer)
            .MaximumLength(64);

        JsonRuleFor(x => x.GroupId)
            .MaximumLength(36);
    }
}
