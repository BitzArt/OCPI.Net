using OCPI.Exceptions.Models.Base;

namespace OCPI.Exceptions;

public class ServerErrorOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Unexpected server error.";

    public ServerErrorOcpiException(string message = DefaultMessage)
        : base(message, OcpiStatusCode.ServerError) { }
}
