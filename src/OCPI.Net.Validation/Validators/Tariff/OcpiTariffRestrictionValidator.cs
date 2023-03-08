using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

public class OcpiTariffRestrictionValidator : HttpValidator<OcpiTariffRestriction>
{
    public OcpiTariffRestrictionValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.StartTime)
            .MaximumLength(5);

        JsonRuleFor(x => x.EndTime)
            .MaximumLength(5);

        JsonRuleFor(x => x.StartDate)
            .MaximumLength(10);

        JsonRuleFor(x => x.EndDate)
            .MaximumLength(10);

        JsonRuleFor(x => x.MinKwh)
            .MustMaxSymbols(10);

        JsonRuleFor(x => x.MaxKwh)
            .MustMaxSymbols(10);

        JsonRuleFor(x => x.MinCurrent)
            .MustMaxSymbols(10);

        JsonRuleFor(x => x.MaxCurrent)
            .MustMaxSymbols(10);

        JsonRuleFor(x => x.MinPower)
            .MustMaxSymbols(10);

        JsonRuleFor(x => x.MaxPower)
            .MustMaxSymbols(10);

        JsonRuleFor(x => x.MinDuration)
            .MustMaxSymbols(10);

        JsonRuleFor(x => x.MaxDuration)
            .MustMaxSymbols(10);

        RuleForEach(x => x.DayOfWeek)
            .MustValidEnum();

        JsonRuleFor(x => x.Reservation)
            .MustValidEnum();
    }
}
