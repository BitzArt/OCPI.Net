using BitzArt.EnumToMemberValue;

namespace OCPI;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
public class OcpiVersionAttribute : Attribute
{
    public OcpiVersion Version { get; set; }

    public OcpiVersionAttribute(string version) :
        this(version.ToEnum<OcpiVersion>())
    { }

    public OcpiVersionAttribute(OcpiVersion version)
    {
        Version = version;
    }
}
