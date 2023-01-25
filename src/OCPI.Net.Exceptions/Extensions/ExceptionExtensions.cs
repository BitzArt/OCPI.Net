using BitzArt.ApiExceptions;
using OCPI.Exceptions;

namespace OCPI;

public static class ExceptionExtensions
{
    public static OcpiResponse ToOcpiResponse(this Exception exception)
    {
        var statusCode = exception is OcpiExceptionBase ocpiException ?
            ocpiException.OcpiStatus : (int)OcpiStatusCode.ServerError;

        var problem = exception is ApiExceptionBase apiException ?
            new ProblemDetails(apiException) : null;

        var response = new OcpiResponse(null, statusCode)
        {
            Problem = problem
        };

        return response;
    }
}
