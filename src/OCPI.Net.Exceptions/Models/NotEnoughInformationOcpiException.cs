namespace OCPI.Exceptions;

public class NotEnoughInformationOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "Missing required information.";

    public NotEnoughInformationOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.NotEnoughInformation, innerException: innerException) { }
}
