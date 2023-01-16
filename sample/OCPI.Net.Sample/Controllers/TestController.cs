using Microsoft.AspNetCore.Mvc;

namespace OCPI.Net.Sample.Controllers;

[ApiController]
[Route("test")]
public class TestsController : OcpiControllerBase
{
    [HttpGet("")]
    public IActionResult Test()
    {
        return Ok(DateTime.UtcNow);
    }
}
