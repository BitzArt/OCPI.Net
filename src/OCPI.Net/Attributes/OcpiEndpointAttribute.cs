using BitzArt.EnumToMemberValue;

namespace OCPI;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public class OcpiEndpointAttribute : Attribute
{
    public OcpiModule Module { get; set; }
    public IEnumerable<InterfaceRole> Roles { get; set; }
    public IEnumerable<OcpiVersion> Versions { get; set; }

    public OcpiEndpointAttribute(OcpiModule module, string roles, string versions)
    {
        Module = module;
        Roles = roles.Split(',').Select(x => x.Trim().ToEnum<InterfaceRole>());
        Versions = versions.Split(',').Select(x => x.Trim().ToEnum<OcpiVersion>());
    }
}
