using OCPI.Contracts;

namespace OCPI.Exceptions;

public class UnknownTokenOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Unknown Token.";

    public UnknownTokenOcpiException(string message = DefaultMessage)
        : base(message, OcpiStatusCode.UnknownToken) { }
}
