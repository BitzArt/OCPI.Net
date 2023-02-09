using BitzArt.ApiExceptions;
using Microsoft.AspNetCore.Mvc;

namespace OCPI.Sample.Controllers;

[Route("exceptions")]
public class OcpiExceptionSampleController : OcpiController
{
    [HttpGet("ocpi")]
    public IActionResult ThrowOcpiException()
    {
        throw OcpiException.Custom("sample error message", 3999);
    }

    [HttpGet("ocpi-custom")]
    public IActionResult ThrowOcpiCustomException()
    {
        throw OcpiException.Custom("sample error message", 3999, 418);
    }

    [HttpGet("other")]
    public IActionResult ThrowOtherException()
    {
        throw new Exception("sample error message");
    }
}
