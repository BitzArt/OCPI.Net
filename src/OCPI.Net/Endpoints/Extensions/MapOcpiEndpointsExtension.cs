using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using OCPI.Endpoints;

namespace OCPI;

public static class UseOcpiEndpointsExtension
{
    private class Result
    {
        public string Test { get; set; }

        public DateTime DateTime { get; set; }

        public Result()
        {
            Test = "Hello World!";
            DateTime = DateTime.UtcNow;
        }
    }

    public static WebApplication MapOcpiEndpoints(this WebApplication app)
    {
        app.MapGet("/ocpi/", () => Results.Json(new Result(), OcpiJsonSerializerOptions.Instance));

        return app;
    }
}
