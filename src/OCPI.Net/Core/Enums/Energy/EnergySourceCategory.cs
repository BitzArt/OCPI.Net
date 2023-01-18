using System.Runtime.Serialization;

namespace OCPI;

public enum EnergySourceCategory : byte
{
    [EnumMember(Value = "GENERAL_FOSSIL")]
    GeneralFossil = 10,

    [EnumMember(Value = "COAL")]
    Coal = 11,

    [EnumMember(Value = "GAS")]
    Gas = 12,

    //======================================

    [EnumMember(Value = "GENERAL_GREEN")]
    GeneralGreen = 20,

    [EnumMember(Value = "SOLAR")]
    Solar = 21,

    [EnumMember(Value = "WIND")]
    Wind = 22,

    [EnumMember(Value = "WATER")]
    Water = 23,

    //======================================

    [EnumMember(Value = "NUCLEAR")]
    Nuclear = 31
}
