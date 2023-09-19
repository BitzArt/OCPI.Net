using FluentValidation;
using OCPI.Contracts;

namespace OCPI.Validation;

internal class OcpiCredentialsValidator : OcpiValidator<OcpiCredentials>
{
    public OcpiCredentialsValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
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
            .SetValidator(new OcpiCredentialsRoleValidator(actionType, ocpiVersion));
    }
}
