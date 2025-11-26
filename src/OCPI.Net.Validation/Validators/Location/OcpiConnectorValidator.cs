using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiConnectorValidator : OcpiValidator<OcpiConnector>
{
    public OcpiConnectorValidator(OcpiValidationContext validationContext) : base(validationContext)
    {
        Unless(ActionType.Patch, () =>
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Standard).NotEmpty();
            RuleFor(x => x.Format).NotEmpty();
            RuleFor(x => x.PowerType).NotEmpty();

            WhenOcpiVersionAbove("2.2", () =>
            {
                RuleFor(x => x.MaxVoltage).NotEmpty();
                RuleFor(x => x.MaxAmperage).NotEmpty();
            });

            WhenOcpiVersionBelow("2.2", () =>
            {
                RuleFor(x => x.Voltage).NotEmpty();
                RuleFor(x => x.Amperage).NotEmpty();
            });
        });

        RuleFor(x => x.Id)
            .MaximumLength(36);

        RuleFor(x => x.Standard)
            .IsInEnum();

        RuleFor(x => x.Format)
            .IsInEnum();

        RuleFor(x => x.PowerType)
            .IsInEnum();

        RuleFor(x => x.TermsAndConditionsUrl)
            .ValidUrl();

        RuleFor(x => x.LastUpdated)
            .NotEmpty()
            .ValidDateTime();
    }
}
