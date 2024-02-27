using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiCredentialsRoleValidator : OcpiValidator<OcpiCredentialsRole>
{
    public OcpiCredentialsRoleValidator(
        IOcpiValidator<OcpiBusinessDetails> businessDetailsValidator)
    {
        RuleFor(x => x.CountryCode)
            .NotEmpty()
            .NotEqual((CountryCode)0);

        RuleFor(x => x.PartyId)
            .NotEmpty()
            .MaximumLength(3);

        RuleFor(x => x.Role)
            .NotEmpty()
            .IsInEnum();

        RuleFor(x => x.BusinessDetails)
            .NotEmpty();

        RuleFor(x => x.BusinessDetails!)
            .SetValidator(businessDetailsValidator);
    }
}
