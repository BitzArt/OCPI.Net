namespace OCPI.Exceptions;

public class ServerErrorOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Unexpected server error.";

    /// <summary>
    /// Creates a new <see cref="ServerErrorOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public ServerErrorOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.ServerError, innerException: innerException) { }
}
