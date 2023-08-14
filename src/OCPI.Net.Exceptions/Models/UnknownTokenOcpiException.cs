namespace OCPI.Exceptions;

public class UnknownTokenOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Unknown Token.";

    public UnknownTokenOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.UnknownToken, innerException: innerException) { }
}
