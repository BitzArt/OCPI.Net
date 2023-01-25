using OCPI.Contracts;

namespace OCPI;

/// <summary>
/// This service scans your codebase and maps all OCPI paths from
/// controllers marked with OcpiEndpoint attribute on startup.
/// </summary>
public interface IOcpiVersionService
{
    /// <summary>
    /// Maps existing routes according to provided template.
    /// Returns data prepared for displaying in OCPI Version Information endpoint.
    /// </summary>
    IEnumerable<OcpiVersionInfo> GetVersions(string template = "[BaseServiceUrl]/versions/[Version]");

    /// <summary>
    /// Maps VersionDetails according to provided template.
    /// Returns data prepared for displaying in OCPI Version Details endpoint.
    /// </summary>
    OcpiVersionDetails GetVersionDetails(string request, string template = "[BaseServiceUrl]/[ModuleRoute]");

    /// <summary>
    /// Maps VersionDetails according to provided template.
    /// Returns data prepared for displaying in OCPI Version Details endpoint.
    /// </summary>
    OcpiVersionDetails GetVersionDetails(OcpiVersion request, string template = "[BaseServiceUrl]/[ModuleRoute]");

    /// <summary>Returns all raw Route Mappings this service knows of.</summary>
    IEnumerable<OcpiEndpointRouteMap> GetRoutes();

    /// <summary>Returns raw Route Mappings that are associated with a specific OCPI Version.</summary>
    IEnumerable<OcpiEndpointRouteMap> GetRoutes(OcpiVersion ocpiVersion);
}