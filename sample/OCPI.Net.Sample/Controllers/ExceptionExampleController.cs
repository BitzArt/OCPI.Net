using Microsoft.AspNetCore.Mvc;
using OCPI.Exceptions;
using System.Text.Json;

namespace OCPI.Net.Sample.Controllers;

[ApiController]
[Route("exception")]
public class ExceptionExampleController : OcpiControllerBase
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
