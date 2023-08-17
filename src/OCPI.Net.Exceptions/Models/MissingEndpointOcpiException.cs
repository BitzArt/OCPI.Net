namespace OCPI.Exceptions;

public class MissingEndpointOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "No matching endpoints or expected endpoints missing between parties.";

    /// <summary>
    /// Creates a new <see cref="MissingEndpointOcpiException"/>
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    /// <param name="innerException">Inner exception</param>
    public MissingEndpointOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.MissingEndpoint, innerException: innerException) { }
}
