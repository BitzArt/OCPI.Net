using OCPI.Exceptions.Models.Base;

namespace OCPI;

public static class ExceptionExtensions
{
    public static OcpiResponse ToOcpiResponse(this Exception exception)
    {
        if (exception is OcpiExceptionBase ocpiException)
        {
            return new(ocpiException.Message, ocpiException.OcpiStatus);
        }

        if (exception.InnerException != null)
        {
            var data = new
            {
                message = exception.Message,
                inner = exception.InnerException.Message
            };
            return new(data, OcpiStatusCode.ServerError);
        }

        return new(exception.Message, OcpiStatusCode.ServerError);
    }
}
