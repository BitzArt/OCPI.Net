using System.Runtime.Serialization;

namespace OCPI
{
    public enum PartyRole : byte
    {
        Undefined = 0,

        //======================================

        /// <summary>
        /// Charge Point Operator Role.
        /// </summary>
        [EnumMember(Value = "CPO")]
        Cpo = 1,

        /// <summary>
        /// eMobility Service Provider Role.
        /// </summary>
        [EnumMember(Value = "EMSP")]
        Emsp = 2,

        //======================================

        /// <summary>
        /// Hub role.
        /// </summary>
        [EnumMember(Value = "HUB")]
        Hub = 11,

        //======================================

        /// <summary>
        /// National Access Point Role
        /// (national Database with all Location information of a country).
        /// </summary>
        [EnumMember(Value = "NAP")]
        Nap = 21,

        /// <summary>
        /// Navigation Service Provider Role, role like an eMSP
        /// (probably only interested in Location information).
        /// </summary>
        [EnumMember(Value = "NSP")]
        Nsp = 31,

        /// <summary>
        /// Smart Charging Service Provider Role.
        /// </summary>
        [EnumMember(Value = "SCSP")]
        Scsp = 32,

        //======================================

        /// <summary>
        /// Other role.
        /// </summary>
        [EnumMember(Value = "OTHER")]
        Other = 255
    }
}
