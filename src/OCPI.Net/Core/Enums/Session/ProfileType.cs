using System.Runtime.Serialization;

namespace OCPI;

public enum ProfileType
{
    /// <summary>
    /// Driver wants to use the cheapest charging profile possible.
    /// </summary>
    [EnumMember(Value = "CHEAP")]
    Cheap = 11,

    //======================================

    /// <summary>
    /// Driver wants his EV charged as quickly as possible and is willing to pay a premium for this, if
    ///needed.
    /// </summary>
    [EnumMember(Value = "FAST")]
    Fast = 21,

    //======================================

    /// <summary>
    /// Driver wants his EV charged with as much regenerative (green) energy as possible.
    /// </summary>
    [EnumMember(Value = "GREEN")]
    Green = 31,

    //======================================

    /// <summary>
    /// Driver does not have special preferences.
    /// </summary>
    [EnumMember(Value = "REGULAR")]
    Regular = 41
}
