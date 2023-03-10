using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiBusinessDetailsValidator : ActionValidator<OcpiBusinessDetails>
{
    public OcpiBusinessDetailsValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);

        JsonRuleFor(x => x.Website)
            .ValidUrl();

        JsonRuleFor(x => x.Logo!)
            .SetValidator(new OcpiImageValidator(actionType));
    }
}
