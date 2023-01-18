using System.Runtime.Serialization;

namespace OCPI;

public enum EvseStatus : byte
{
    [EnumMember(Value = "AVAILABLE")]
    Available = 11,

    //======================================

    [EnumMember(Value = "CHARGING")]
    Charging = 21,

    //======================================

    [EnumMember(Value = "BLOCKED")]
    Blocked = 31,

    //======================================

    [EnumMember(Value = "INOPERATIVE")]
    Inoperative = 41,

    [EnumMember(Value = "OUTOFORDER")]
    OutOfOrder = 42,

    //======================================

    [EnumMember(Value = "PLANNED")]
    Planned = 51,

    [EnumMember(Value = "RESERVED")]
    Reserved = 52,

    //======================================

    [EnumMember(Value = "REMOVED")]
    Removed = 61,

    //======================================

    [EnumMember(Value = "UNKNOWN")]
    Unknown = 255
}
