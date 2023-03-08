using FluentValidation;
using OCPI.Validation;
using System.Text.Json.Serialization;

namespace OCPI.Contracts;

internal partial class OcpiPublishTokenTypeValidator : HttpValidator<OcpiPublishTokenType>
{
    public OcpiPublishTokenTypeValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.Uid)
            .MaximumLength(36);

        JsonRuleFor(x => x.Type)
            .ValidEnum();

        JsonRuleFor(x => x.VisualNumber)
            .MaximumLength(64);

        JsonRuleFor(x => x.Issuer)
            .MaximumLength(64);

        JsonRuleFor(x => x.GroupId)
            .MaximumLength(36);
    }
}
