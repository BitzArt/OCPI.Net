using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiHoursValidator : OcpiValidator<OcpiHours>
{
    public OcpiHoursValidator(
        OcpiValidationContext validationContext,
        IOcpiValidator<OcpiRegularHours> regularHoursValidator,
        IOcpiValidator<OcpiExceptionalPeriod> exceptionalPeriodValidator)
        : base(validationContext)
    {
        RuleFor(x => x.TwentyFourSeven)
            .NotEmpty();

        RuleForEach(x => x.RegularHours)
            .SetValidator(regularHoursValidator);

        RuleForEach(x => x.ExceptionalOpenings)
            .SetValidator(exceptionalPeriodValidator);

        RuleForEach(x => x.ExceptionalClosings)
            .SetValidator(exceptionalPeriodValidator);
    }
}
