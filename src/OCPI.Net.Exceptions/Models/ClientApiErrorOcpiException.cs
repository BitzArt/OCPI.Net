namespace OCPI.Exceptions;

public class ClientApiErrorOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Unable to use the client’s API.";

    /// <summary>
    /// Creates a new <see cref="ClientApiErrorOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public ClientApiErrorOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.ClientApiError, innerException: innerException) { }
}
