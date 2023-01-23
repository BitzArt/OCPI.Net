namespace OCPI;

public interface IOcpiVersionService
{
    IEnumerable<OcpiEndpointRouteMap> GetRoutes();
    IEnumerable<OcpiEndpointRouteMap> GetRoutes(OcpiVersion ocpiVersion);
    IEnumerable<OcpiVersion> GetVersions();
}