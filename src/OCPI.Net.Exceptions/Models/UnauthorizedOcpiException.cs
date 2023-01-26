using BitzArt.ApiExceptions;

namespace OCPI.Exceptions;

public class UnauthorizedOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Authorization header is missing or the credentials token doesn’t match any known party.";

    public UnauthorizedOcpiException(string message = DefaultMessage)
        : base(message, OcpiStatusCode.ClientError, ApiStatusCode.Unauthorized) { }
}
