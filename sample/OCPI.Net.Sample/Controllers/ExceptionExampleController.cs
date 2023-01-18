using Microsoft.AspNetCore.Mvc;

namespace OCPI.Net.Sample.Controllers;

[ApiController]
[Route("exception")]
public class ExceptionExampleController : ControllerBase
{
    [HttpGet("")]
    public IActionResult ThrowException()
    {
        var exception = OcpiException.ServerError("Error message");
        exception.Payload.AddData(new
        {
            a = "a",
            b = 123
        });

        throw exception;
    }
}
