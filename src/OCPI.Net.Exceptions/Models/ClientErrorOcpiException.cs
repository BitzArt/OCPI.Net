namespace OCPI.Exceptions;

public class ClientErrorOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Client error. Contact platform's owner for more details.";

    public ClientErrorOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.ClientError, innerException: innerException) { }
}
