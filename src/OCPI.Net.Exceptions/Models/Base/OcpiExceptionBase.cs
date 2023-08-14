using BitzArt.ApiExceptions;

namespace OCPI.Exceptions;

public abstract class OcpiExceptionBase : ApiExceptionBase
{
    public int OcpiStatus { get; set; }

    public OcpiExceptionBase(string message, OcpiStatusCode ocpiStatusCode, ApiStatusCode apiStatusCode = ApiStatusCode.OK, Exception? innerException = null)
        : base(message, apiStatusCode, innerException: innerException)
    {
        OcpiStatus = (int)ocpiStatusCode;
    }

    public OcpiExceptionBase(string message, int ocpiStatusCode, ApiStatusCode statusCode = ApiStatusCode.OK, Exception? innerException = null)
        : base(message, statusCode, innerException: innerException)
    {
        OcpiStatus = ocpiStatusCode;
    }

    public OcpiExceptionBase(string message, int ocpiStatusCode, int httpStatusCode, Exception? innerException = null)
        : base(message, httpStatusCode, innerException: innerException)
    {
        OcpiStatus = ocpiStatusCode;
    }
}
