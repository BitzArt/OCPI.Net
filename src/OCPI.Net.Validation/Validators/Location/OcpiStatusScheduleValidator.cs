using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiStatusScheduleValidator : HttpValidator<OcpiStatusSchedule>
{
    public OcpiStatusScheduleValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.PeriodBegin)
            .NotEmpty()
            .ValidDateTime();

        JsonRuleFor(x => x.PeriodEnd)
            .ValidDateTime();

        JsonRuleFor(x => x.Status)
            .NotEmpty()
            .ValidEnum();
    }
}
