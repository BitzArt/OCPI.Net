using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiConnectorValidator : OcpiValidator<OcpiConnector>
{
    public OcpiConnectorValidator(string httpMethod) : base(httpMethod)
    {
        When(x => !IsPatch, () =>
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
            .MustValidEnum();

        JsonRuleFor(x => x.Format)
            .MustValidEnum();

        JsonRuleFor(x => x.PowerType)
            .MustValidEnum();

        JsonRuleFor(x => x.TermsAndConditionsUrl)
            .MustValidUrl();

        JsonRuleFor(x => x.LastUpdated)
            .NotEmpty()
            .MustValidDateTime();
    }
}
