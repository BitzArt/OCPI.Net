using System.Runtime.Serialization;

namespace OCPI;

public enum CommandResponseType : byte
{
    //====================1x: Success========================

    /// <summary>
    /// Command request accepted by the CPO.
    /// </summary>
    [EnumMember(Value = "ACCEPTED")]
    Accepted = 11,

    //====================2x: Rejected========================

    /// <summary>
    /// Command request rejected by the CPO.
    /// </summary>
    [EnumMember(Value = "REJECTED")]
    Rejected = 21,

    /// <summary>
    /// The Session in the requested command is not known by this CPO.
    /// </summary>
    [EnumMember(Value = "UNKNOWN_SESSION")]
    Unknown_session = 22,

    //====================3x: Error========================

    /// <summary>
    /// The requested command is not supported by this CPO, Charge Point, EVSE etc.
    /// </summary>
    [EnumMember(Value = "NOT_SUPPORTED")]
    Not_supported = 31
}
