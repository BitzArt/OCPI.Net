using System.Runtime.Serialization;

namespace OCPI.Enums.SmartCharging;

public enum ChargingProfileResponseType : byte
{
    //====================1x: Success========================

    /// <summary>
    /// ChargingProfile request accepted by the CPO, request will be forwarded to the EVSE.
    /// </summary>
    [EnumMember(Value = "ACCEPTED")]
    Accepted = 11,

    //====================2x: Rejected========================

    /// <summary>
    /// ChargingProfile request rejected by the CPO. (Session might not be from a customer of the eMSP
    /// that send this request)
    /// </summary>
    [EnumMember(Value = "REJECTED")]
    Rejected = 21,

    /// <summary>
    /// ChargingProfile request rejected by the CPO, requests are send more often then allowed.
    /// </summary>
    [EnumMember(Value = "TOO_OFTEN")]
    TooOften = 22,

    //====================3x: Fail========================

    /// <summary>
    /// The ChargingProfiles not supported by this CPO, Charge Point, EVSE etc.
    /// </summary>
    [EnumMember(Value = "NOT_SUPPORTED")]
    NotSupported = 31,

    /// <summary>
    /// The Session in the requested command is not known by this CPO.
    /// </summary>
    [EnumMember(Value = "UNKNOWN_SESSION")]
    UnknownSession = 32,
}
