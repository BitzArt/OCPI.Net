using FluentValidation;
using OCPI.Contracts;

namespace OCPI.Validation;

internal class OcpiCredentialsValidator : ActionValidator<OcpiCredentials>
{
    public OcpiCredentialsValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.Token)
            .NotEmpty()
            .NoWhitespace()
            .InUnicodeRange(0x0021, 0x007E)
            .MaximumLength(64);

        JsonRuleFor(x => x.Url)
            .NotEmpty()
            .ValidUrl()
            .MaximumLength(2048);

        JsonRuleFor(x => x.Roles)
            .NotEmpty();

        RuleForEach(x => x.Roles!)
            .SetValidator(new OcpiCredentialsRoleValidator(actionType));
    }
}
