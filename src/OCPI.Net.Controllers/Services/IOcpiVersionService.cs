using BitzArt.Pagination;
using OCPI.Contracts;

namespace OCPI;

/// <summary>
/// This service scans your codebase and maps all OCPI paths from
/// controllers marked with OcpiEndpoint attribute on startup.
/// </summary>
public interface IOcpiVersionService
{
    /// <summary>
    /// Maps existing routes according to the template defined in OcpiOptions.
    /// Returns data prepared for displaying in OCPI Version Information endpoint.
    /// </summary>
    IEnumerable<OcpiVersionInfo> GetVersions();

    /// <summary>
    /// Maps VersionDetails according to the template defined in OcpiOptions.
    /// Returns data prepared for displaying in OCPI Version Details endpoint.
    /// </summary>
    OcpiVersionDetails GetVersionDetails(string request);

    /// <summary>
    /// Maps VersionDetails according to the template defined in OcpiOptions.
    /// Returns data prepared for displaying in OCPI Version Details endpoint.
    /// </summary>
    OcpiVersionDetails GetVersionDetails(OcpiVersion request);

    /// <summary>Returns all raw route mappings this service knows of.</summary>
    IEnumerable<OcpiEndpointRouteMap> GetRoutes();

    /// <summary>Returns raw route mappings that are associated with a specific OCPI Version.</summary>
    IEnumerable<OcpiEndpointRouteMap> GetRoutes(OcpiVersion ocpiVersion);

    /// <summary>Returns a raw route mapping that is associated with a specific OCPI Version and a specific controller.</summary>
    OcpiEndpointRouteMap GetEndpointMap(OcpiVersion version, Type controllerType);
}