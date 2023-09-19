using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiCredentialsRoleValidator : OcpiValidator<OcpiCredentialsRole>
{
    public OcpiCredentialsRoleValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.CountryCode)
            .NotEmpty()
            .NotEqual((CountryCode)0);

        JsonRuleFor(x => x.PartyId)
            .NotEmpty()
            .MaximumLength(3);

        JsonRuleFor(x => x.Role)
            .NotEmpty()
            .IsInEnum();

        JsonRuleFor(x => x.BusinessDetails)
            .NotEmpty();

        JsonRuleFor(x => x.BusinessDetails!)
            .SetValidator(new OcpiBusinessDetailsValidator(actionType, ocpiVersion));
    }
}
