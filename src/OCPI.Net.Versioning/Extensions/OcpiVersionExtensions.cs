namespace OCPI;

public static class OcpiVersionExtensions
{
    public static bool RequiresTokenEncoding(this OcpiVersion version)
    {
        return version >= OcpiVersion.v2_2;
    }
}
