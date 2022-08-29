namespace OCPI.Exceptions;

public class MissingEndpointOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "No matching endpoints or expected endpoints missing between parties.";

    public MissingEndpointOcpiException(string message = DefaultMessage)
        : base(message, OcpiStatusCode.MissingEndpoint) { }
}
