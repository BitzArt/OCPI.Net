using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OCPI.Exceptions;

namespace OCPI.Filters;

public class OcpiExceptionFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;
        var response = exception.ToOcpiResponse();

        var statusCode = exception is OcpiExceptionBase ocpi ?
            ocpi.OcpiLayerHttpStatusCode : 200;

        context.Result = new ObjectResult(response)
        {
            StatusCode = statusCode
        };
    }
}
