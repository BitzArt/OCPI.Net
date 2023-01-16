using BitzArt.ApiExceptions;
using OCPI.Exceptions;

namespace OCPI;

public static class ExceptionExtensions
{
    public static OcpiResponse ToOcpiResponse(this Exception exception)
    {
        ProblemDetails details;

        if (exception is ApiExceptionBase apiException) details = new(apiException);
        else details = new(exception);

        return new OcpiResponse(details, OcpiStatusCode.ServerError);
    }
}
