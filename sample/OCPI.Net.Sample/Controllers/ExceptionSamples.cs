using BitzArt;
using Microsoft.AspNetCore.Mvc;

namespace OCPI.Sample.Controllers;

[Route("exceptions")]
public class OcpiExceptionSampleController : OcpiController
{
    [HttpGet("ocpi-exception")]
    public IActionResult ThrowOcpiException()
    {
        throw OcpiException.Custom("sample error message", OcpiStatusCode.ServerError);
    }

    [HttpGet("api-exception")]
    public IActionResult ThrowApiException()
    {
        throw ApiException.Custom("sample error message", 418);
    }

    [HttpGet("other")]
    public IActionResult ThrowOtherException()
    {
        throw new Exception("sample error message");
    }
}
