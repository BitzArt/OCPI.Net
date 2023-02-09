using BitzArt.ApiExceptions;

namespace OCPI.Exceptions;

public abstract class OcpiExceptionBase : ApiExceptionBase
{
    public int OcpiStatus { get; set; }

    public OcpiExceptionBase(string message, OcpiStatusCode ocpiStatusCode, ApiStatusCode apiStatusCode = ApiStatusCode.OK)
        : base(message, apiStatusCode)
    {
        OcpiStatus = (int)ocpiStatusCode;
    }

    public OcpiExceptionBase(string message, int ocpiStatusCode, ApiStatusCode statusCode = ApiStatusCode.OK)
        : base(message, statusCode)
    {
        OcpiStatus = ocpiStatusCode;
    }

    public OcpiExceptionBase(string message, int ocpiStatusCode, int httpStatusCode)
        : base(message, httpStatusCode)
    {
        OcpiStatus = ocpiStatusCode;
    }
}
