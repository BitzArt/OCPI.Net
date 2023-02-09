using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace OCPI.Filters;

public class OcpiExceptionFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;
        var response = exception.ToOcpiResponse();
        var statusCode = exception.GetHttpStatusCode();

        context.Result = new ObjectResult(response)
        {
            StatusCode = statusCode
        };
    }
}
