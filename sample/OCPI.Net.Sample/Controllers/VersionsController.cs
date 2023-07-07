using Microsoft.AspNetCore.Mvc;

namespace OCPI.Sample.Controllers;

[Route("versions")]
public class VersionsController : OcpiController
{
    // This service scans your codebase and maps all OCPI paths from
    // controllers marked with OcpiEndpoint attribute on startup.
    private readonly IOcpiVersionService _versionService;

    public VersionsController(IOcpiVersionService versionService)
    {
        _versionService = versionService;
    }

    [HttpGet]
    public IActionResult GetVersionsAsync()
    {
        var versionInfo = _versionService.GetVersions();
        return OcpiOk(versionInfo);
    }

    [HttpGet("{request}")]
    public IActionResult GetVersionDetailsAsync([FromRoute] string request)
    {
        var details = _versionService.GetVersionDetails(request);
        return OcpiOk(details);
    }
}