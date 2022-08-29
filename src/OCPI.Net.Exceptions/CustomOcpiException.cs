namespace OCPI.Exceptions;

public class CustomOcpiException : OcpiExceptionBase
{
    public CustomOcpiException(string message, OcpiStatusCode ocpiStatusCode)
        : this(message, (int)ocpiStatusCode) { }

    public CustomOcpiException(string message, int ocpiStatusCode)
        : base(message, ocpiStatusCode) { }
}
