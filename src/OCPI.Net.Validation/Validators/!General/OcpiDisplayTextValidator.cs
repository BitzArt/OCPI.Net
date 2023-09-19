using FluentValidation;

namespace OCPI.Contracts;

internal class OcpiDisplayTextValidator : OcpiValidator<OcpiDisplayText>
{
    public OcpiDisplayTextValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.Language)
            .NotEmpty()
            .MaximumLength(2);

        JsonRuleFor(x => x.Text)
            .NotEmpty()
            .MaximumLength(512);
    }
}
