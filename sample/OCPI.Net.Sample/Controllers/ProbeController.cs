using Microsoft.AspNetCore.Mvc;

namespace OCPI.Net.Sample.Controllers;

[ApiController]
[Route("")]
public class ProbeController : ControllerBase
{
    [HttpGet("")]
    public IActionResult Probe()
    {
        return Ok("It's good to be alive");
    }
}