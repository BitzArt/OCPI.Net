using BitzArt.ApiExceptions;
using OCPI.Exceptions;

namespace OCPI;

public static class ExceptionExtensions
{
    public static OcpiResponse ToOcpiResponse(this Exception exception)
    {
        var statusCode = exception is OcpiExceptionBase ocpiException ?
            ocpiException.OcpiStatus :
            (int)OcpiStatusCode.ServerError;

        var details = exception is ApiExceptionBase apiException ?
            new ProblemDetails(apiException) :
            new ProblemDetails(exception);

        return new OcpiResponse(details, statusCode);
    }
}
