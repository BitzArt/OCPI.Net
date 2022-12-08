using BitzArt.ApiExceptions;

namespace OCPI.Exceptions.Models.Base;

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
}
