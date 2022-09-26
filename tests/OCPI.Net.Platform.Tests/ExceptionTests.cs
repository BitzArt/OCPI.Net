using System.Text.Json;

namespace OCPI.Tests;

public class OcpiResponseTests
{
    [Fact]
    public void Exception_ToOcpiResponse_ProperResult()
    {
        var message = "some text";
        var exception = new Exception(message);

        var response = exception.ToOcpiResponse();

        Assert.Equal((int)OcpiStatusCode.ServerError, response.StatusCode);
        var json = JsonSerializer.Serialize(response);
        Assert.Contains(message, json);
    }

    [Fact]
    public void OcpiException_ToOcpiResponse_ProperResult()
    {
        var ocpiStatusCode = OcpiStatusCode.Success;
        var message = "some text";
        var exception = OcpiException.Custom(message, ocpiStatusCode);

        var response = exception.ToOcpiResponse();

        Assert.Equal((int)ocpiStatusCode, response.StatusCode);
        var json = JsonSerializer.Serialize(response);
        Assert.Contains(message, json);
    }
}