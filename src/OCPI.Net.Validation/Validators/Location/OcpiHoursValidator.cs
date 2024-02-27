using FluentValidation;

namespace OCPI.Contracts;

internal partial class OcpiHoursValidator : OcpiValidator<OcpiHours>
{
    public OcpiHoursValidator(
        IOcpiValidator<OcpiRegularHours> regularHoursValidator,
        IOcpiValidator<OcpiExceptionalPeriod> exceptionalPeriodValidator)
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
