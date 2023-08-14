using BitzArt.ApiExceptions;

namespace OCPI.Exceptions;

public class CustomOcpiException : OcpiExceptionBase
{
    public CustomOcpiException(string message, OcpiStatusCode ocpiStatusCode, ApiStatusCode apiStatusCode = ApiStatusCode.OK, Exception? innerException = null)
        : base(message, ocpiStatusCode, apiStatusCode, innerException) { }

    public CustomOcpiException(string message, int ocpiStatusCode, ApiStatusCode apiStatusCode = ApiStatusCode.OK, Exception? innerException = null)
        : base(message, ocpiStatusCode, apiStatusCode, innerException) { }

    public CustomOcpiException(string message, int ocpiStatusCode, int httpStatusCode, Exception? innerException = null)
        : base(message, ocpiStatusCode, httpStatusCode, innerException) { }
}
