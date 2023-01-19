using BitzArt.EnumToMemberValue;

namespace OCPI;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
public class InterfaceRoleAttribute : Attribute
{
    public InterfaceRole Role { get; set; }

    public InterfaceRoleAttribute(string role) :
        this(role.ToEnum<InterfaceRole>())
    { }

    public InterfaceRoleAttribute(InterfaceRole role)
    {
        Role = role;
    }
}
