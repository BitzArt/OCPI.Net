using System.Runtime.Serialization;

namespace OCPI;

public enum AllowedType : byte
{
    //====================1x: Allowed========================
    /// <summary>
    /// This Token is allowed to charge (at this location).
    /// </summary>
    [EnumMember(Value = "ALLOWED")]
    Allowed = 11,

    //====================2x: Not Allowed========================

    /// <summary>
    /// This Token is blocked.
    /// </summary>
    [EnumMember(Value = "BLOCKED")]
    Blocked = 21,

    /// <summary>
    /// This Token has expired.
    /// </summary>
    [EnumMember(Value = "EXPIRED")]
    Expired = 22,

    /// <summary>
    /// This Token belongs to an account that has not enough credits to charge (at the given location).
    /// </summary>
    [EnumMember(Value = "NO_CREDIT")]
    NoCredit = 23,

    /// <summary>
    /// Token is valid, but is not allowed to charge at the given location.
    /// </summary>
    [EnumMember(Value = "NOT_ALLOWED")]
    NotAllowed = 24


}