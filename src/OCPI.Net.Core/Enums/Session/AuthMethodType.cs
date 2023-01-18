using System.Runtime.Serialization;

namespace OCPI;

public enum AuthMethodType : byte
{
    /// <summary>
    /// Authentication request has been sent to the eMSP.
    /// </summary>
    [EnumMember(Value = "AUTH_REQUEST")]
    AuthRequest = 11,

    //======================================

    /// <summary>
    /// Command like StartSession or ReserveNow used to start the Session, 
    /// the Token provided in the Command was used as authorization.
    /// </summary>
    [EnumMember(Value = "COMMAND")]
    Command = 21,

    //======================================

    /// <summary>
    /// Whitelist used for authentication, no request to the eMSP has been performed.
    /// </summary>
    [EnumMember(Value = "WHITELIST")]
    Whitelist = 31,
}
