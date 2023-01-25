using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiCredentialsRoleValidator : OcpiValidator<OcpiCredentialsRole>
{
    public OcpiCredentialsRoleValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.CountryCode)
            .NotEmpty()
            .NotEqual((CountryCode)0);

        JsonRuleFor(x => x.PartyId)
            .NotEmpty()
            .MaximumLength(3);

        JsonRuleFor(x => x.Role)
            .NotEmpty()
            .MustValidEnum();

        JsonRuleFor(x => x.BusinessDetails)
            .NotEmpty();

        JsonRuleFor(x => x.BusinessDetails!)
            .SetValidator(new OcpiBusinessDetailsValidator(httpMethod));
    }
}
