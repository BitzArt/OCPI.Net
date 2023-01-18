using BitzArt.EnumToMemberValue;
using OCPI.Contracts;

namespace OCPI;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
public class OcpiEndpointAttribute : Attribute
{
    public InterfaceRole Role { get; set; }
    public ModuleId ModuleId { get; set; }
    public IEnumerable<OcpiVersion> Versions { get; set; }

    public OcpiEndpointAttribute(ModuleId moduleId, InterfaceRole role, string versions) :
        this(moduleId, role, ParseVersions(versions)) { }

    public OcpiEndpointAttribute(ModuleId moduleId, InterfaceRole role, IEnumerable<OcpiVersion> versions)
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
