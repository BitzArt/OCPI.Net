using OCPI.Validation;
using System.Text.Json.Serialization;

namespace OCPI.Contracts;

internal class OcpiEnergyMixValidator : OcpiValidator<OcpiEnergyMix>
{
    public OcpiEnergyMixValidator(string httpMethod) : base(httpMethod)
    {
    }
}
