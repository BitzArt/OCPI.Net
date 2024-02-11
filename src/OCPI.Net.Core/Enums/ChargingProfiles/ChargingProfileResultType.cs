using System.Runtime.Serialization;

namespace OCPI.Enums.ChargingProfiles;

public enum ChargingProfileResultType
{
    //====================1x: Success========================

    /// <summary>
    /// ChargingProfile request accepted by the EVSE.
    /// </summary>
    [EnumMember(Value = "ACCEPTED")]
    Accepted = 11,

    //====================2x: Rejected========================

    /// <summary>
    /// ChargingProfile request rejected by the EVSE.
    /// </summary>
    [EnumMember(Value = "REJECTED")]
    Rejected = 21,

    //====================3x: Unknown========================

    /// <summary>
    /// No Charging Profile(s) were found by the EVSE matching the request.
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown = 31,
}
