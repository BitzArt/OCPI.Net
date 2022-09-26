using System.Runtime.Serialization;

namespace OCPI
{
    public enum PlatformPartyRole : byte
    {
        Undefined = 0,

        //======================================

        [EnumMember(Value = "CPO")]
        Cpo = 1,

        [EnumMember(Value = "EMSP")]
        Emsp = 2,

        //======================================

        [EnumMember(Value = "HUB")]
        Hub = 11,

        //======================================

        [EnumMember(Value = "NAP")]
        Nap = 21,

        [EnumMember(Value = "NSP")]
        Nsp = 31,

        [EnumMember(Value = "SCSP")]
        Scsp = 32,

        //======================================

        [EnumMember(Value = "OTHER")]
        Other = 255
    }
}
