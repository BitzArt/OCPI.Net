using OCPI.Contracts;

namespace OCPI.Exceptions;

public class InvalidParametersOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Invalid or missing parameters.";

    public InvalidParametersOcpiException(string message = DefaultMessage)
        : base(message, OcpiStatusCode.InvalidParameters) { }
}
