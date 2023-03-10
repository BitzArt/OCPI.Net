using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiImageValidator : ActionValidator<OcpiImage>
{
    public OcpiImageValidator(ActionType actionType) : base(actionType)
    {
        JsonRuleFor(x => x.Url)
            .NotEmpty()
            .ValidUrl();

        JsonRuleFor(x => x.Thumbnail)
            .ValidUrl();

        JsonRuleFor(x => x.Category)
            .NotEmpty()
            .ValidEnum();

        JsonRuleFor(x => x.Type)
            .NotEmpty()
            .MaximumLength(4);

        JsonRuleFor(x => x.Width)
            .MaxSymbols(5);

        JsonRuleFor(x => x.Height)
            .MaxSymbols(5);
    }
}
