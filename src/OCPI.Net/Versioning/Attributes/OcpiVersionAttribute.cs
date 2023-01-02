using BitzArt.EnumToMemberValue;

namespace OCPI.Versioning
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class OcpiVersionAttribute : Attribute
    {
        public OcpiVersion Version { get; set; }

        public OcpiVersionAttribute(OcpiVersion version)
        {
            Version = version;
        }

        public OcpiVersionAttribute(string version)
        {
            Version = version.ToEnum<OcpiVersion>();
        }
    }
}
