using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiCredentialsRoleValidator : ActionValidator<OcpiCredentialsRole>
{
    public OcpiCredentialsRoleValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.CountryCode)
            .NotEmpty()
            .NotEqual((CountryCode)0);

        JsonRuleFor(x => x.PartyId)
            .NotEmpty()
            .MaximumLength(3);

        JsonRuleFor(x => x.Role)
            .NotEmpty()
            .ValidEnum();

        JsonRuleFor(x => x.BusinessDetails)
            .NotEmpty();

        JsonRuleFor(x => x.BusinessDetails!)
            .SetValidator(new OcpiBusinessDetailsValidator(actionType));
    }
}
