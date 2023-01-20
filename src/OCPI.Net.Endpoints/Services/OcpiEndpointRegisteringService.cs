using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing.Patterns;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace OCPI.Services;

internal class OcpiEndpointRegisteringService
{
    public readonly OcpiEndpointMappingService _mapper;

    public OcpiEndpointRegisteringService(OcpiEndpointMappingService mapper)
    {
        _mapper = mapper;
    }

    public void RegisterOcpiEndpoints(WebApplication app)
    {
        var routes = _mapper
            .GetRoutes()
            .OrderBy(x => x.EndpointType);

        foreach (var route in routes) RegisterOcpiEndpointRoute(app, route);
    }

    public void RegisterOcpiEndpointRoute(WebApplication app, OcpiEndpointRoute route)
    {
        var methods = route
            .EndpointType
            .GetMethods()
            .Where(x => x.IsPublic);

        foreach (var method in methods) ProcessOcpiEndpointMethod(app, route, method);
    }

    private void ProcessOcpiEndpointMethod(WebApplication app, OcpiEndpointRoute route, MethodInfo method)
    {
        var methods = method.GetCustomAttributes<HttpMethodAttribute>();
        foreach (var httpMethod in methods) RegisterOcpiEndpointMethod(app, route, method, httpMethod);
    }

    private void RegisterOcpiEndpointMethod(WebApplication app, OcpiEndpointRoute route, MethodInfo method, HttpMethodAttribute attribute)
    {
        var path = string.IsNullOrWhiteSpace(attribute.Template) ? route.Route : $"{route.Route}/{attribute.Template}";

        var del = CreateDelegate(app, route.EndpointType, method);

        app.Map(path, del);
    }

    private static Delegate CreateDelegate(WebApplication app, Type endpointType, MethodInfo method)
    {
        var types = method
            .GetParameters()
            .Select(p => p.ParameterType)
            .Concat(new[] { method.ReturnType })
            .ToArray();

        var type = Expression.GetFuncType(types);

        return Delegate.CreateDelegate(type, GetEndpoint(app, endpointType, method), method);
    }

    private static OcpiEndpoint GetEndpoint(WebApplication app, Type endpointType, MethodInfo method)
    {
        using var scope = app.Services.CreateScope();
        var endpoint = (OcpiEndpoint)scope.ServiceProvider.GetService(endpointType)!;
        return endpoint;
    }
}
