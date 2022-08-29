namespace OCPI.Exceptions;

public class CustomOcpiException : OcpiExceptionBase
{
    public CustomOcpiException(string message, OcpiStatusCode ocpiStatusCode)
        : base(message, ocpiStatusCode) { }
}
