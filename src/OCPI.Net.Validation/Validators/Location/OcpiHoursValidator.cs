using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiHoursValidator : HttpValidator<OcpiHours>
{
    public OcpiHoursValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.TwentyFourSeven)
            .NotEmpty();

        RuleForEach(x => x.RegularHours)
            .SetValidator(new OcpiRegularHoursValidator(httpMethod));

        RuleForEach(x => x.ExceptionalOpenings)
            .SetValidator(new OcpiExceptionalPeriodValidator(httpMethod));

        RuleForEach(x => x.ExceptionalClosings)
            .SetValidator(new OcpiExceptionalPeriodValidator(httpMethod));
    }
}
