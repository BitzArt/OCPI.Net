using FluentValidation;
using OCPI.Contracts;

namespace OCPI.Validators;

public class ImageViewModelValidator : JsonValidator<ImageViewModel>
{
    public ImageViewModelValidator()
    {
        JsonRuleFor(x => x.Url).NotEmpty().MaximumLength(255);

        JsonRuleFor(x => x.Thumbnail).MaximumLength(255);

        JsonRuleFor(x => x.Category).NotNull();

        JsonRuleFor(x => x.Type).NotEmpty().MaximumLength(4);

        JsonRuleFor(x => x.Width).InclusiveBetween(1, 99999);

        JsonRuleFor(x => x.Height).InclusiveBetween(1, 99999);
    }
}
