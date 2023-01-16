using Microsoft.AspNetCore.Mvc;
using OCPI;
using System.Text.Json;

namespace OCPI.Net.Sample.Controllers;

[ApiController]
[Route("")]
public class ProbeController : OcpiControllerBase
{
    [HttpGet("")]
    public IActionResult Probe()
    {
        return Ok("It's good to be alive");
    }
}
