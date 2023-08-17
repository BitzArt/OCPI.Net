namespace OCPI.Exceptions;

public class NotEnoughInformationOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Missing required information.";

    /// <summary>
    /// Creates a new <see cref="NotEnoughInformationOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public NotEnoughInformationOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.NotEnoughInformation, innerException: innerException) { }
}
