using BitzArt.ApiExceptions;

namespace OCPI.Exceptions;

public class CustomOcpiException : OcpiExceptionBase
{
    public CustomOcpiException(string message, OcpiStatusCode ocpiStatusCode, ApiStatusCode apiStatusCode = ApiStatusCode.OK)
        : base(message, ocpiStatusCode, apiStatusCode) { }

    public CustomOcpiException(string message, int ocpiStatusCode, ApiStatusCode apiStatusCode = ApiStatusCode.OK)
        : base(message, ocpiStatusCode, apiStatusCode) { }

    public CustomOcpiException(string message, int ocpiStatusCode, int httpStatusCode)
        : base(message, ocpiStatusCode, httpStatusCode) { }
}
