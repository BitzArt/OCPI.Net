namespace OCPI.Exceptions;

public class ClientErrorOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Client error. Contact platform's owner for more details.";

    /// <summary>
    /// Creates a new <see cref="ClientErrorOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public ClientErrorOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.ClientError, innerException: innerException) { }
}
