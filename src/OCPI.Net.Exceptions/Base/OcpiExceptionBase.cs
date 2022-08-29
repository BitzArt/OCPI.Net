using BitzArt.ApiExceptions;
using System.Net;

namespace OCPI.Exceptions;

public abstract class OcpiExceptionBase : ApiExceptionBase
{
    public OcpiStatusCode OcpiStatusCode { get; set; }

    public OcpiExceptionBase(string message, OcpiStatusCode ocpiStatusCode, ApiStatusCode statusCode = ApiStatusCode.OK)
        : base(message, statusCode)
    {
        OcpiStatusCode = ocpiStatusCode;
    }
}
