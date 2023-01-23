using BitzArt.EnumToMemberValue;
using Microsoft.AspNetCore.Mvc;

namespace OCPI.Services;

internal class OcpiVersionService : IOcpiVersionService
{
    private readonly ICollection<OcpiEndpointRouteMap> _routeMaps;

    private readonly IDictionary<OcpiVersion, ICollection<OcpiEndpointRouteMap>> _versionRouteMaps;

    public OcpiVersionService()
    {
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

    public IEnumerable<OcpiVersion> GetVersions() => _versionRouteMaps.Keys;

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
