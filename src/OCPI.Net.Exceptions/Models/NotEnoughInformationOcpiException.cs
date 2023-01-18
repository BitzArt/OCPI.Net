namespace OCPI.Exceptions;

public class NotEnoughInformationOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Missing required information.";

    public NotEnoughInformationOcpiException(string message = DefaultMessage)
        : base(message, OcpiStatusCode.NotEnoughInformation) { }
}
