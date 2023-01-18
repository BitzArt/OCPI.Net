namespace OCPI.Exceptions;

public class UnsupportedVersionOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "OCPI version not supported.";

    public UnsupportedVersionOcpiException(string message = DefaultMessage)
        : base(message, OcpiStatusCode.UnsupportedVersion) { }
}
