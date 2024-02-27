using FluentValidation;

namespace OCPI.Contracts;

internal class OcpiTariffRestrictionsValidator : OcpiValidator<OcpiTariffRestrictions>
{
    public OcpiTariffRestrictionsValidator()
    {
        RuleFor(x => x.StartTime)
            .MaximumLength(5);

        RuleFor(x => x.EndTime)
            .MaximumLength(5);

        RuleFor(x => x.StartDate)
            .MaximumLength(10);

        RuleFor(x => x.EndDate)
            .MaximumLength(10);

        RuleForEach(x => x.DayOfWeek)
            .IsInEnum();

        RuleFor(x => x.Reservation)
            .IsInEnum();
    }
}
