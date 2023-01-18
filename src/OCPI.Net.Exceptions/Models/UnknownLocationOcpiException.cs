using OCPI.Contracts;

namespace OCPI.Exceptions;

public class UnknownLocationOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Unknown Location.";

    public UnknownLocationOcpiException(string message = DefaultMessage)
        : base(message, OcpiStatusCode.UnknownLocation) { }
}
