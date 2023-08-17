using BitzArt.ApiExceptions;

namespace OCPI.Exceptions;

public class UnauthorizedOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Authorization header is missing or the credentials token doesn’t match any known party.";

    /// <summary>
    /// Creates a new <see cref="UnauthorizedOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public UnauthorizedOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.ClientError, ApiStatusCode.Unauthorized, innerException: innerException) { }
}
