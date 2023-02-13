using OCPI.Validation;
using System.Text.Json.Serialization;

namespace OCPI.Contracts;

internal class OcpiEnvironmentalImpactValidator : OcpiValidator<OcpiEnvironmentalImpact>
{
    public OcpiEnvironmentalImpactValidator(string httpMethod) : base(httpMethod)
    {
    }
}
