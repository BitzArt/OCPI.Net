namespace OCPI.Exceptions;

public class InvalidParametersOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Invalid or missing parameters.";

    public InvalidParametersOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.InvalidParameters, innerException: innerException) { }
}
