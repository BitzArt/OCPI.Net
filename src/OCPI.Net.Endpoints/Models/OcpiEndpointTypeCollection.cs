namespace OCPI;

internal class OcpiEndpointTypeCollection
{
    public IEnumerable<Type> EndpointTypes { get; set; }

    public OcpiEndpointTypeCollection(IEnumerable<Type> endpointTypes)
    {
        EndpointTypes = endpointTypes;
    }
}
