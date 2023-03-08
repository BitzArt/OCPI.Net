using FluentValidation;
using OCPI.Contracts;

namespace OCPI.Validation;

internal class OcpiCredentialsValidator : HttpValidator<OcpiCredentials>
{
    public OcpiCredentialsValidator(string httpMethod) : base(httpMethod)
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
            .SetValidator(new OcpiCredentialsRoleValidator(httpMethod));
    }
}
