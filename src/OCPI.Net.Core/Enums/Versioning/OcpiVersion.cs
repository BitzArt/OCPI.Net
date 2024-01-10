using System.Runtime.Serialization;

namespace OCPI;

public enum OcpiVersion : byte
{
    [EnumMember(Value = "2.0")]
    v2_0 = 200,

    [EnumMember(Value = "2.1")]
    v2_1 = 210,

    [EnumMember(Value = "2.1.1")]
    v2_1_1 = 211,

    [EnumMember(Value = "2.2")]
    v2_2 = 220,

    [EnumMember(Value = "2.2.1")]
    v2_2_1 = 221
}
