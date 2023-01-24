using Microsoft.AspNetCore.Mvc;

namespace OCPI.Sample.Controllers;

[Route("versions")]
public class VersionsController : OcpiController
{
    private readonly IOcpiVersionService _versions;

    public VersionsController(IOcpiVersionService versions)
    {
        _versions = versions;
    }

    [HttpGet]
    public IActionResult GetVersionsAsync()
    {
        return Ok(_versions.GetVersions());
    }

    [HttpGet("{request}")]
    public IActionResult GetVersionDetailsAsync([FromRoute]string request)
    {
        return Ok(_versions.GetVersionDetails(request));
    }
}