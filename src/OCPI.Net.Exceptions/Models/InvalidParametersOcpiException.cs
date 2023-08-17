namespace OCPI.Exceptions;

public class InvalidParametersOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Invalid or missing parameters.";

    /// <summary>
    /// Creates a new <see cref="InvalidParametersOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public InvalidParametersOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.InvalidParameters, innerException: innerException) { }
}
