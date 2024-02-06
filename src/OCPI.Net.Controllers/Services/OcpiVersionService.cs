using BitzArt.EnumToMemberValue;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OCPI.Contracts;

namespace OCPI.Versioning.Services;

internal class OcpiVersionService : IOcpiVersionService
{
    private readonly OcpiOptions _options;
    private readonly ILogger<OcpiVersionService> _logger;

    private readonly ICollection<OcpiEndpointRouteMap> _routeMaps;

    private readonly IDictionary<OcpiVersion, ICollection<OcpiEndpointRouteMap>> _versionRouteMaps;

    public OcpiVersionService(OcpiOptions options, ILogger<OcpiVersionService> logger)
    {
        _options = options;
        _logger = logger;

        _logger.LogInformation("Initializing OcpiVersionService");

        _routeMaps = new HashSet<OcpiEndpointRouteMap>();
        _versionRouteMaps = new Dictionary<OcpiVersion, ICollection<OcpiEndpointRouteMap>>();

        var controllerTypes = AppDomain
            .CurrentDomain
            .GetAssemblies()
            .SelectMany(x => x.DefinedTypes)
            .Where(x => !x.IsAbstract)
            .Where(x => typeof(OcpiController).IsAssignableFrom(x))
            .ToList();

        _logger.LogInformation("{count} OCPI Controllers found", controllerTypes.Count);

        foreach (var type in controllerTypes) ParseEndpoint(type);

        _logger.LogInformation("OCPI Controllers parsed successfully");
    }

    public IEnumerable<OcpiEndpointRouteMap> GetRoutes() => _routeMaps;

    public IEnumerable<OcpiVersionInfo> GetVersions()
    {
        var template = _options.VersionListTemplate;

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

    public OcpiVersionDetails GetVersionDetails(string request)
    {
        try
        {
            var version = request.ToEnum<OcpiVersion>();
            return GetVersionDetails(version);
        }
        catch (Exception ex)
        {
            throw OcpiException.ClientError($"Invalid OCPI Version: '{request}'.", ex);
        }
    }

    public OcpiVersionDetails GetVersionDetails(OcpiVersion request)
    {
        var exists = _versionRouteMaps.TryGetValue(request, out var routes);
        if (!exists) throw OcpiException.ClientError($"This platform does not support OCPI version '{request.ToMemberValue()}'.");

        var result = new OcpiVersionDetails()
        {
            Version = request,
            Endpoints = routes!.Select(GetEndpoint)
        };

        return result;
    }

    public OcpiEndpointRouteMap GetEndpointMap(OcpiVersion version, Type controllerType)
    {
        var exists = _versionRouteMaps.TryGetValue(version, out var routes);
        if (!exists) throw OcpiException.ClientError($"This platform does not support OCPI version '{version.ToMemberValue()}'.");

        return routes!.Single(x => x.ControllerType == controllerType);
    }

    private OcpiEndpoint GetEndpoint(OcpiEndpointRouteMap route)
    {
        var url = _options.ModuleTemplate
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

        _logger.LogDebug("Parsing OCPI endpoints for Controller {ControllerName}...", type.Name);

        var routes = GetAttributes<RouteAttribute>(type).Select(x => x.Template).ToList();

        foreach (var version in endpoint.Versions)
        {
            var route = FindRouteForVersion(version, endpoint.Versions, routes, type.Name);

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

    private string FindRouteForVersion(OcpiVersion version, IEnumerable<OcpiVersion> allVersions, IEnumerable<string> routes, string controllerName)
    {
        var target = version.ToMemberValue();

        _logger.LogDebug("Attempting to find a matching route for OCPI Version {version}", target);

        var otherVersions = allVersions
            .Except(new[] { version })
            .Select(x => x.ToMemberValue())
            .ToList();

        var badMatches = new List<string>();

        foreach (var route in routes)
        {
            if (!route.Contains(target)) continue;

            _logger.LogDebug("Route '{route}' matched with OCPI Version {target}", route, target);

            var otherMatches = otherVersions.Where(route.Contains).ToList();
            if (otherMatches.Any())
            {
                _logger.LogDebug("Route '{route}' also matched with other OCPI Versions this endpoint implements.", route);
                
                if (otherMatches.All(target.Contains))
                {
                    _logger.LogDebug("Version conflict successfully resolved, using route '{route}'", route);
                    return route;
                }
                
                _logger.LogDebug("Version conflict could not be resolved, keeping '{route}' as bad match for version '{version}'", route, target);
                badMatches.Add(route);
                continue;
            }

            _logger.LogDebug("A good match was found!");

            return route;
        }

        if (!badMatches.Any()) throw new RouteNotFoundForOcpiVersionException($"No matching route was found for Controller {controllerName} and OCPI Version {version.ToMemberValue()}");

        _logger.LogWarning("No good matches were found for Endpoint {endpoint} and OcpiVersion {target}, using a bad match.", controllerName, target);
        return badMatches.First();
    }

    internal class RouteNotFoundForOcpiVersionException : Exception
    {
        public RouteNotFoundForOcpiVersionException(string controllerName, string version) : base($"Unable to find a matching route for Controller {controllerName} and OCPI Version {version}") { }

        public RouteNotFoundForOcpiVersionException(string message) : base(message)
        {
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
