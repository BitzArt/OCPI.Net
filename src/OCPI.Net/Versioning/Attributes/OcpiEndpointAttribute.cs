namespace OCPI.Versioning
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class OcpiEndpointAttribute : Attribute
    {
        public InterfaceRole Role { get; set; }
        public ModuleId ModuleId { get; set; }
        public string Versions { get; set; }

        public OcpiEndpointAttribute(ModuleId moduleId, InterfaceRole role, string versions)
        {
            Role = role;
            ModuleId = moduleId;
            Versions = versions;
        }
    }
}
