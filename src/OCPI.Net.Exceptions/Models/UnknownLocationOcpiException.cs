namespace OCPI.Exceptions;

public class UnknownLocationOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Unknown Location.";

    public UnknownLocationOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.UnknownLocation, innerException: innerException) { }
}
