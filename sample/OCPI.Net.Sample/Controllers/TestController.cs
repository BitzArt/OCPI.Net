using Microsoft.AspNetCore.Mvc;

namespace OCPI.Net.Sample.Controllers;

[ApiController]
[Route("test")]
public class TestsController : ControllerBase
{
    [HttpGet("")]
    public IActionResult Test()
    {
        return Ok(DateTime.UtcNow);
    }
}
