using BitzArt.Pagination;
using Microsoft.AspNetCore.Mvc;
using OCPI.Contracts;

namespace OCPI.Sample.Controllers;

// Work In Progress

[OcpiEndpoint(OcpiModule.Credentials, "Receiver", "2.2, 2.2.1")]
[Route("2.2/credentials")]
[Route("2.2.1/credentials")]
public class CredentialsController : OcpiController
{
    [HttpGet]
    public IActionResult GetPageResult([FromQuery] OcpiPageRequest pageRequest)
    {
        SetMaxLimit(pageRequest, 10);
        return OcpiOk(Enumerable.Range(1, 100).ToPage(pageRequest));
    }
}