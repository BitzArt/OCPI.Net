namespace OCPI.Exceptions;

public class ClientApiErrorOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Unable to use the client’s API.";

    public ClientApiErrorOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.ClientApiError, innerException: innerException) { }
}
