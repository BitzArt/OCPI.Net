namespace OCPI;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
public class OcpiModuleAttribute : Attribute
{
    public OcpiModule ModuleId { get; set; }

    public OcpiModuleAttribute(string moduleId)

    public OcpiModuleAttribute(OcpiModule moduleId)
    {
        ModuleId = moduleId;
    }
}
