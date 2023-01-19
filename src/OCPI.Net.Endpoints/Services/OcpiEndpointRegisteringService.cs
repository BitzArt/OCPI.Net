using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OCPI.Services;

internal class OcpiEndpointRegisteringService
{
    public OcpiEndpointMappingService _mapper { get; }

    public OcpiEndpointRegisteringService(OcpiEndpointMappingService mapper)
    {
        _mapper = mapper;
    }

    [OcpiModule(OcpiModule.Unknown)]
    [InterfaceRole(InterfaceRole.Receiver)]
    [OcpiVersion("2.2.1")]
    [OcpiVersion("2.2")]
    internal class TestEndpoint : OcpiEndpoint
    {
        [HttpGet("smthn")]
        public IResult DoSomething()
        {
            return Results.Ok();
        }
    }

    public void RegisterOcpiEndpoints(WebApplication app)
    {
        var endpointTypes = _mapper.GetEndpointTypes();
        foreach (var type in endpointTypes) RegisterOcpiEndpoint(app, type);
    }

    private void RegisterOcpiEndpoint(WebApplication app, Type type)
    {
        var routes = _mapper.GetRoutes(type);
        var response = routes.Select(x => x.Route);
        foreach (var route in routes)
        {
            app.MapGet(route.Route, () => Results.Json(response, OcpiJsonSerializerOptions.Instance));
        }
    }
}
