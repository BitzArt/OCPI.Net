namespace OCPI.Exceptions;

public class ServerErrorOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Unexpected server error.";

    public ServerErrorOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.ServerError, innerException: innerException) { }
}
