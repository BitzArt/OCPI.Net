namespace OCPI.Exceptions;

public class UnknownTokenOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Unknown Token.";

    /// <summary>
    /// Creates a new <see cref="UnknownTokenOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public UnknownTokenOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.UnknownToken, innerException: innerException) { }
}
