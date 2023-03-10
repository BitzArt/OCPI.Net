using FluentValidation;

namespace OCPI.Contracts;

internal class OcpiDisplayTextValidator : ActionValidator<OcpiDisplayText>
{
    public OcpiDisplayTextValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.Language)
            .NotEmpty()
            .MaximumLength(2);

        JsonRuleFor(x => x.Text)
            .NotEmpty()
            .MaximumLength(512);
    }
}
