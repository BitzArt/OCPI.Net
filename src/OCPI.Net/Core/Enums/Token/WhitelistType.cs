using System.Runtime.Serialization;

namespace OCPI;

public enum WhitelistType
{
    /// <summary>
    /// Token always has to be whitelisted, realtime authorization is not possible/allowed. CPO shall
    /// always allow any use of this Token.
    /// </summary>
    [EnumMember(Value = "ALWAYS")]
    Always = 11,

    //======================================

    /// <summary>
    /// It is allowed to whitelist the token, realtime authorization is also allowed. The CPO may choose
    /// which version of authorization to use.
    /// </summary>
    [EnumMember(Value = "ALLOWED")]
    Allowed = 21,

    /// <summary>
    /// In normal situations realtime authorization shall be used. But when the CPO cannot get a response
    /// from the eMSP (communication between CPO and eMSP is offline), the CPO shall allow this Token
    /// to be used.
    /// </summary>
    [EnumMember(Value = "ALLOWED_OFFLINE")]
    AllowedOffline = 22,

    //======================================

    /// <summary>
    /// Whitelisting is forbidden, only realtime authorization is allowed. CPO shall always send a realtime
    /// authorization for any use of this Token to the eMSP.
    /// </summary>
    [EnumMember(Value = "NEVER")]
    Never = 31
}
