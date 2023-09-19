using BitzArt.EnumToMemberValue;

namespace OCPI;

/// <summary>
/// Marks the OCPI protocol elements that were deprecated in one of the previous OCPI versions.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Delegate, Inherited = false)]
public class OcpiDeprecatedAttribute : Attribute
{
    private readonly OcpiVersion _lastVersion;

    /// <summary>
    /// Initializes a new instance of the <see cref="OcpiDeprecatedAttribute"/> by string representation of the last OCPI version that uses this value.
    /// </summary>
    /// <param name="after">A string representation of the last OCPI Version that uses this class/object/method</param>
    public OcpiDeprecatedAttribute(string after)
    {
        _lastVersion = after.ToEnum<OcpiVersion>();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OcpiDeprecatedAttribute"/> by the last OCPI version that uses this value.
    /// </summary>
    /// <param name="after">The last OCPI Version that uses this class/object/method</param>
    public OcpiDeprecatedAttribute(OcpiVersion after)
    {
        _lastVersion = after;
    }

    // TODO: ? Add a compiler error when used with a wrong OCPI version ? TBD
}
