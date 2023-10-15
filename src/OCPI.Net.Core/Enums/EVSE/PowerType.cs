using System.Runtime.Serialization;

namespace OCPI;

public enum PowerType : byte
{
    [EnumMember(Value = "DC")]
    Dc = 11,

    //======================================

    [EnumMember(Value = "AC_1_PHASE")]
    Ac1Phase = 21,

    //======================================

    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "AC_2_PHASE")]
    Ac2Phase = 31,

    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "AC_2_PHASE_SPLIT")]
    Ac2PhaseSplit = 32,

    //======================================

    [EnumMember(Value = "AC_3_PHASE")]
    Ac3Phase = 41
}
