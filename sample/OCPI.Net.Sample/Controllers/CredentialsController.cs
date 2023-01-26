using BitzArt.Pagination;
using Microsoft.AspNetCore.Mvc;
using OCPI.Contracts;

namespace OCPI.Sample.Controllers;

//This file is a Work In Progress

[OcpiEndpoint(OcpiModule.Credentials, "Receiver", "2.2, 2.2.1")]
[Route("2.2/credentials")]
[Route("2.2.1/credentials")]
public class CredentialsController : OcpiControllerBase
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

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] OcpiCredentials credentials)
    {
        OcpiValidate(credentials);
        return Ok();
    }
}