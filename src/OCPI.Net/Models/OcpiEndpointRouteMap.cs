namespace OCPI;

public class OcpiEndpointRouteMap
{
    public required string Route { get; init; }

    public required Type ControllerType { get; init; }

    public required OcpiVersion OcpiVersion { get; init; }
    public required OcpiModule OcpiModule { get; init; }
    public required InterfaceRole InterfaceRole { get; init; }
}
