using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiConnectorValidator : OcpiValidator<OcpiConnector>
{
    public OcpiConnectorValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        Unless(ActionType.Patch, () =>
        {
            JsonRuleFor(x => x.Id).NotEmpty();
            JsonRuleFor(x => x.Standard).NotEmpty();
            JsonRuleFor(x => x.Format).NotEmpty();
            JsonRuleFor(x => x.PowerType).NotEmpty();
            JsonRuleFor(x => x.MaxVoltage).NotEmpty();
            JsonRuleFor(x => x.MaxAmperage).NotEmpty();
        });

        JsonRuleFor(x => x.Id)
            .MaximumLength(36);

        JsonRuleFor(x => x.Standard)
            .IsInEnum();

        JsonRuleFor(x => x.Format)
            .IsInEnum();

        JsonRuleFor(x => x.PowerType)
            .IsInEnum();

        JsonRuleFor(x => x.TermsAndConditionsUrl)
            .ValidUrl();

        JsonRuleFor(x => x.LastUpdated)
            .NotEmpty()
            .ValidDateTime();
    }
}
