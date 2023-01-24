using OCPI.Contracts;

namespace OCPI;

public interface IOcpiVersionService
{
    IEnumerable<OcpiVersionInfo> GetVersions(string template = "[BaseServiceUrl]/versions/[Version]");

    OcpiVersionDetails GetVersionDetails(string request, string template = "[BaseServiceUrl]/[ModuleRoute]");
    OcpiVersionDetails GetVersionDetails(OcpiVersion request, string template = "[BaseServiceUrl]/[ModuleRoute]");

    IEnumerable<OcpiEndpointRouteMap> GetRoutes();
    IEnumerable<OcpiEndpointRouteMap> GetRoutes(OcpiVersion ocpiVersion);
}