using OCPI.Contracts;

namespace OCPI.Exceptions;

public class ClientApiErrorOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Unable to use the client’s API.";

    public ClientApiErrorOcpiException(string message = DefaultMessage)
        : base(message, OcpiStatusCode.ClientApiError) { }
}
