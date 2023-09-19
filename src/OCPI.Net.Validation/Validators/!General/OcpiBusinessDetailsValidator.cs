using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiBusinessDetailsValidator : OcpiValidator<OcpiBusinessDetails>
{
    public OcpiBusinessDetailsValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);

        JsonRuleFor(x => x.Website)
            .ValidUrl();

        JsonRuleFor(x => x.Logo!)
            .SetValidator(new OcpiImageValidator(actionType, ocpiVersion));
    }
}
