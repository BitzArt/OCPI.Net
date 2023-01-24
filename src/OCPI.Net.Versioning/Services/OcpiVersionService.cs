using BitzArt.EnumToMemberValue;
using Microsoft.AspNetCore.Mvc;
using OCPI.Contracts;
using System;

namespace OCPI.Versioning.Services;

internal class OcpiVersionService : IOcpiVersionService
{
    private readonly OcpiOptions _options;

    private readonly ICollection<OcpiEndpointRouteMap> _routeMaps;

    private readonly IDictionary<OcpiVersion, ICollection<OcpiEndpointRouteMap>> _versionRouteMaps;

    public OcpiVersionService(OcpiOptions options)
    {
        _options = options;

        _routeMaps = new HashSet<OcpiEndpointRouteMap>();
        _versionRouteMaps = new Dictionary<OcpiVersion, ICollection<OcpiEndpointRouteMap>>();

        var controllerTypes = AppDomain
            .CurrentDomain
            .GetAssemblies()
            .SelectMany(x => x.DefinedTypes)
            .Where(x => !x.IsAbstract)
            .Where(x => typeof(OcpiController).IsAssignableFrom(x));

        foreach (var type in controllerTypes) ParseEndpoint(type);
    }

    public IEnumerable<OcpiEndpointRouteMap> GetRoutes() => _routeMaps;

    public IEnumerable<OcpiVersionInfo> GetVersions(string template = "[BaseServiceUrl]/versions/[Version]")
    {
        if (string.IsNullOrWhiteSpace(template)) throw new ArgumentException("template not found");
        CheckTemplateContainsElement(template, TemplateElementNames.BaseServiceUrl);
        CheckTemplateContainsElement(template, TemplateElementNames.Version);

        return _versionRouteMaps
            .Select(x => x.Key)
            .Select(x => GetVersionInfo(x, template))
            .OrderBy(x => x.Version);
    }

    private OcpiVersionInfo GetVersionInfo(OcpiVersion version, string template)
    {
        var url = template
            .Replace(GetTemplateElement(TemplateElementNames.BaseServiceUrl), _options.BaseServiceUrl)
            .Replace(GetTemplateElement(TemplateElementNames.Version), version.ToMemberValue());

        return new OcpiVersionInfo
        {
            Version = version,
            Url = url
        };
    }

    public OcpiVersionDetails GetVersionDetails(string request, string template = "[BaseServiceUrl]/[ModuleRoute]")
    {
        var version = request.ToEnum<OcpiVersion>(OcpiVersion.Invalid);
        if (version == OcpiVersion.Invalid) throw OcpiException.ClientError($"Invalid OCPI Version: '{request}'.");

        return GetVersionDetails(version, template);
    }

    public OcpiVersionDetails GetVersionDetails(OcpiVersion request, string template = "[BaseServiceUrl]/[ModuleRoute]")
    {
        var exists = _versionRouteMaps.TryGetValue(request, out var routes);

        if (!exists) throw OcpiException.ClientError($"Version '{request.ToMemberValue()}' not implemented.");

        var result = new OcpiVersionDetails()
        {
            Version = request,
            Endpoints = routes!.Select(x => GetEndpoint(x, template))
        };

        return result;
    }

    private OcpiEndpoint GetEndpoint(OcpiEndpointRouteMap route, string template = "[BaseServiceUrl]/[ModuleRoute]")
    {
        var url = template
            .Replace(GetTemplateElement(TemplateElementNames.BaseServiceUrl), _options.BaseServiceUrl)
            .Replace(GetTemplateElement(TemplateElementNames.ModuleRoute), route.Route);

        return new OcpiEndpoint
        {
            Identifier = route.OcpiModule,
            Role = route.InterfaceRole,
            Url = url
        };
    }

    private static void CheckTemplateContainsElement(string template, string element)
    {
        var search = GetTemplateElement(element);
        if (!template.Contains(search)) throw new ArgumentException($"template must contain {search}");
    }

    private static string GetTemplateElement(string element) => "[" + element + "]";

    public IEnumerable<OcpiEndpointRouteMap> GetRoutes(OcpiVersion ocpiVersion)
        => _versionRouteMaps[ocpiVersion];

    private void ParseEndpoint(Type type)
    {
        var endpoint = GetAttribute<OcpiEndpointAttribute>(type);
        if (endpoint is null) return;

        var routes = GetAttributes<RouteAttribute>(type).Select(x => x.Template);

        foreach (var version in endpoint.Versions)
        {
            var route = routes.FirstOrDefault(x => x.StartsWith(version.ToMemberValue()));
            if (route is null) throw new Exception($"Appropriate route not found for Controller {type.Name} and OCPI Version {version.ToMemberValue()}");

            foreach (var role in endpoint.Roles)
            {
                var map = new OcpiEndpointRouteMap
                {
                    ControllerType = type,
                    OcpiModule = endpoint.Module,
                    InterfaceRole = role,
                    OcpiVersion = version,
                    Route = route
                };
                _routeMaps.Add(map);
                AddToVersionMap(version, map);
            }
        }
    }

    private void AddToVersionMap(OcpiVersion version, OcpiEndpointRouteMap route)
    {
        var versionPresent = _versionRouteMaps.TryGetValue(version, out var map);
        if (!versionPresent)
        {
            map = new List<OcpiEndpointRouteMap> { route };
            _versionRouteMaps.Add(version, map);
        }
        else map!.Add(route);
    }

    private static T GetAttribute<T>(Type type)
        where T : class =>
        (Attribute.GetCustomAttribute(type, typeof(T)) as T)!;

    private static IEnumerable<T> GetAttributes<T>(Type type)
        where T : class =>
        (Attribute.GetCustomAttributes(type, typeof(T)) as T[])!;
}
