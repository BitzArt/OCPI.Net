namespace OCPI.Exceptions;

public class UnsupportedVersionOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "OCPI version not supported.";

    /// <summary>
    /// Creates a new <see cref="UnsupportedVersionOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public UnsupportedVersionOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.UnsupportedVersion, innerException: innerException) { }
}
