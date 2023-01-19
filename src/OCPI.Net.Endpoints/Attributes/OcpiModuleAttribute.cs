using BitzArt.EnumToMemberValue;

namespace OCPI;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
public class OcpiModuleAttribute : Attribute
{
    public OcpiModule Module { get; set; }

    public OcpiModuleAttribute(string module) :
        this(module.ToEnum<OcpiModule>())
    { }

    public OcpiModuleAttribute(OcpiModule module)
    {
        Module = module;
    }
}
