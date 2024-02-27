namespace OCPI.Exceptions;

/// <summary>
/// Creates a new <see cref="ClientApiErrorOcpiException"/>
/// </summary>
/// <param name="message">Message to be displayed</param>
/// <param name="innerException">Inner exception</param>
public class ClientApiErrorOcpiException(string message = ClientApiErrorOcpiException.DefaultMessage, Exception? innerException = null) : OcpiExceptionBase(message, OcpiStatusCode.ClientApiError, innerException: innerException)
{
    public const string DefaultMessage = "Unable to use the client’s API.";
}
