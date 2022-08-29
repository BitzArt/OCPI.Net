namespace OCPI.Exceptions;

public class ClientErrorOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Client error. Contact platform's owner for more details.";

    public ClientErrorOcpiException(string message = DefaultMessage)
        : base(message, OcpiStatusCode.ClientError) { }
}
