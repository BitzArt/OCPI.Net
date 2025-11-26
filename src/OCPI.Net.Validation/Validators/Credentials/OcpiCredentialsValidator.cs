using FluentValidation;
using OCPI.Contracts;

namespace OCPI.Validation;

internal class OcpiCredentialsValidator : OcpiValidator<OcpiCredentials>
{
    public OcpiCredentialsValidator(
        OcpiValidationContext validationContext,
        IOcpiValidator<OcpiCredentialsRole> credentialsRoleValidator)
        :base(validationContext)
    {
        RuleFor(x => x.Token)
            .NotEmpty()
            .NoWhitespace()
            .InUnicodeRange(0x0021, 0x007E)
            .MaximumLength(64);

        RuleFor(x => x.Url)
            .NotEmpty()
            .ValidUrl()
            .MaximumLength(2048);

        RuleFor(x => x.Roles)
            .NotEmpty();

        RuleForEach(x => x.Roles!)
            .SetValidator(credentialsRoleValidator);
    }
}
