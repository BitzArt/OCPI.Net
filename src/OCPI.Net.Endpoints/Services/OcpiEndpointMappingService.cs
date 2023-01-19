using BitzArt.EnumToMemberValue;

namespace OCPI.Services;

internal class OcpiEndpointMappingService
{
    private readonly IEnumerable<Type> _endpoints;
    private readonly IDictionary<Type, ICollection<OcpiEndpointRoute>> _typeMap;
    private readonly IDictionary<OcpiVersion, ICollection<OcpiEndpointRoute>> _versionMap;

    public OcpiEndpointMappingService(OcpiEndpointTypeCollection endpointTypeCollection)
    {
        _endpoints = endpointTypeCollection.EndpointTypes;

        _typeMap = new Dictionary<Type, ICollection<OcpiEndpointRoute>>();
        _versionMap = new Dictionary<OcpiVersion, ICollection<OcpiEndpointRoute>>();

        foreach (var type in _endpoints) ParseEndpoint(type);
    }

    public IEnumerable<Type> GetEndpointTypes() => _endpoints;

    public IEnumerable<OcpiEndpointRoute> GetRoutes(Type endpointType)
        => _typeMap[endpointType];

    public IEnumerable<OcpiEndpointRoute> GetRoutes(OcpiVersion ocpiVersion)
        => _versionMap[ocpiVersion];

    private void ParseEndpoint(Type type)
    {
        var versions = GetAttributes<OcpiVersionAttribute>(type)
            .Select(x => x.Version);
        if (!versions.Any()) return;

        var modules = GetAttributes<OcpiModuleAttribute>(type)
            .Select(x => x.Module);
        if (!modules.Any()) return;

        var roles = GetAttributes<InterfaceRoleAttribute>(type)
            .Select(x => x.Role);

        _typeMap.Add(type, new List<OcpiEndpointRoute>());

        foreach (var version in versions)
            foreach (var module in modules)
                foreach (var role in roles)
                    AddRoute(type, version, module, role);
    }

    private void AddRoute(Type type, OcpiVersion version, OcpiModule module, InterfaceRole role)
    {
        var route = new OcpiEndpointRoute
        {
            OcpiVersion = version,
            OcpiModule = module,
            InterfaceRole = role,

            EndpointType = type,

            Route = $"/{version.ToMemberValue()}/{module.ToMemberValue()}"
        };
        AddToTypeMap(type, route);
        AddToVersionMap(version, route);
    }

    private void AddToTypeMap(Type type, OcpiEndpointRoute route)
    {
        _typeMap[type].Add(route);
    }

    private void AddToVersionMap(OcpiVersion version, OcpiEndpointRoute route)
    {
        var versionPresent = _versionMap.TryGetValue(version, out var map);
        if (!versionPresent)
        {
            map = new List<OcpiEndpointRoute> { route };
            _versionMap.Add(version, map);
        }
        else map!.Add(route);
    }

    private static IEnumerable<T> GetAttributes<T>(Type type) =>
        (Attribute.GetCustomAttributes(type, typeof(T)) as T[])!;
}
