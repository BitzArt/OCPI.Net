using FluentValidation;
using OCPI.Contracts;

namespace OCPI.Validators;

public class DisplayTextViewModelValidator : JsonValidator<DisplayTextViewModel>
{
    public DisplayTextViewModelValidator()
    {
        JsonRuleFor(x => x.Text).NotEmpty().MaximumLength(512);

        JsonRuleFor(x => x.Language).NotEmpty().MaximumLength(2);
    }
}
