using Microsoft.AspNetCore.Mvc;

namespace OCPI.Sample.Endpoints;

[OcpiModule(OcpiModule.Credentials)]
[InterfaceRole(InterfaceRole.Receiver)]
[OcpiVersion("2.2")]
[OcpiVersion("2.2.1")]
public class CredentialsEndpoint : OcpiEndpoint
{
    public CredentialsEndpoint()
    {
    }

    [HttpGet("test/{id}")]
    public string GetAsync(int id)
    {
        return $"Credentials {id}";
    }
}