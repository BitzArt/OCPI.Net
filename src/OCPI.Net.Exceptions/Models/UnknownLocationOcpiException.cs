namespace OCPI.Exceptions;

public class UnknownLocationOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Unknown Location.";

    /// <summary>
    /// Creates a new <see cref="UnknownLocationOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public UnknownLocationOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.UnknownLocation, innerException: innerException) { }
}
