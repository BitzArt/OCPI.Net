using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiPublishTokenTypeValidator : ActionValidator<OcpiPublishTokenType>
{
    public OcpiPublishTokenTypeValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.Uid)
            .MaximumLength(36);

        JsonRuleFor(x => x.Type)
            .ValidEnum();

        JsonRuleFor(x => x.VisualNumber)
            .MaximumLength(64);

        JsonRuleFor(x => x.Issuer)
            .MaximumLength(64);

        JsonRuleFor(x => x.GroupId)
            .MaximumLength(36);
    }
}
