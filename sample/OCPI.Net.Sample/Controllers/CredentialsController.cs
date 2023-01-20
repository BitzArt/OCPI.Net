using Microsoft.AspNetCore.Mvc;

namespace OCPI.Sample.Controllers;

[OcpiEndpoint(OcpiModule.Credentials, "Receiver", "2.2, 2.2.1")]
[Route("2.2/credentials")]
[Route("2.2.1/credentials")]
public class CredentialsController : OcpiController
{
    public CredentialsController()
    {
    }

    [HttpGet]
    public IActionResult GetAsync()
    {
        var id = 0;
        return Ok($"Credentials {id}");
    }
}