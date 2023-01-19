namespace OCPI;

internal class OcpiEndpointRoute
{
    public required string Route { get; set; }

    public required Type EndpointType { get; set; }

    public required OcpiVersion OcpiVersion { get; set; }
    public required OcpiModule OcpiModule { get; set; }
    public required InterfaceRole InterfaceRole { get; set; }
}
