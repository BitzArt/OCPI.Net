using BitzArt.EnumToMemberValue;
using OCPI.Contracts;

namespace OCPI;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
public class InterfaceRoleAttribute : Attribute
{
    public InterfaceRole Role { get; set; }

    public OcpiEndpointAttribute(OcpiModule moduleId, InterfaceRole role, string versions) :
        this(moduleId, role, ParseVersions(versions)) { }

    public OcpiEndpointAttribute(OcpiModule moduleId, InterfaceRole role, IEnumerable<OcpiVersion> versions)
    {
        Role = role;
        ModuleId = moduleId;
        Versions = versions;
    }

    private static IEnumerable<OcpiVersion> ParseVersions(string versions) =>
        versions
        .Split(separator)
        .Select(x => x
            .Trim()
            .ToEnum<OcpiVersion>());

    private const char separator = ';';
}
