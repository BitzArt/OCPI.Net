using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiEnergySourceValidator : OcpiValidator<OcpiEnergySource>
{
    public OcpiEnergySourceValidator(string httpMethod) : base(httpMethod)
    {
    }
}
