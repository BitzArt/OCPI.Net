namespace OCPI.Models;

internal class OcpiEndpointRouteMap
{
    public required Type EndpointType { get; set; }

    public IEnumerable<OcpiEndpointRoute> Routes { get; set; }
        = new HashSet<OcpiEndpointRoute>();
}
