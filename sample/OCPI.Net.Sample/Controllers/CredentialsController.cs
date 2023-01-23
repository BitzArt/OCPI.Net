using BitzArt.Pagination;
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
        var result = new PageResult(new List<string> { "value1", "value2" }, 0, 2, 10);
        return OcpiOk(result);
    }
}