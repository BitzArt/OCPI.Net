using BitzArt.ApiExceptions;

namespace OCPI.Exceptions;

public abstract class OcpiExceptionBase : ApiExceptionBase
{
    public int OcpiStatusCode { get; set; }

    public OcpiExceptionBase(string message, OcpiStatusCode ocpiStatusCode, ApiStatusCode statusCode = ApiStatusCode.OK)
        : this(message, (int)ocpiStatusCode, statusCode) { }

    public OcpiExceptionBase(string message, int ocpiStatusCode, ApiStatusCode statusCode = ApiStatusCode.OK)
        : base(message, statusCode)
    {
        OcpiStatusCode = ocpiStatusCode;
    }
}
