using System.Runtime.Serialization;

namespace OCPI.Contracts
{
    public enum PowerType : byte
    {
        [EnumMember(Value = "DC")]
        Dc = 11,

        //======================================

        [EnumMember(Value = "AC_1_PHASE")]
        Ac1Phase = 21,

        //======================================

        [EnumMember(Value = "AC_2_PHASE")]
        Ac2Phase = 31,

        [EnumMember(Value = "AC_2_PHASE_SPLIT")]
        Ac2PhaseSplit = 32,

        //======================================

        [EnumMember(Value = "AC_3_PHASE")]
        Ac3Phase = 41
    }
}
