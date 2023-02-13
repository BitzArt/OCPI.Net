using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiStatusScheduleValidator : OcpiValidator<OcpiStatusSchedule>
{
    public OcpiStatusScheduleValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.PeriodBegin)
            .NotEmpty()
            .MustValidDateTime();

        JsonRuleFor(x => x.PeriodEnd)
            .MustValidDateTime();

        JsonRuleFor(x => x.Status)
            .NotEmpty()
            .MustValidEnum();
    }
}
