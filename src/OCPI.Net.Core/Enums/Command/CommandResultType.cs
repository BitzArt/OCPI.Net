using System.Runtime.Serialization;

namespace OCPI;

public enum CommandResultType : byte
{
    /// <summary>
    /// Command request accepted by the Charge Point.
    /// </summary>
    [EnumMember(Value = "ACCEPTED")]
    Accepted = 11,

    //======================================

    /// <summary>
    /// The Reservation has been canceled by the CPO.
    /// </summary>
    [EnumMember(Value = "CANCELED_RESERVATION")]
    CanceledReservation = 21,

    /// <summary>
    /// The Reservation in the requested command is not known by this Charge Point.
    /// </summary>
    [EnumMember(Value = "UNKNOWN_RESERVATION")]
    UnknownReservation = 22,

    //======================================

    /// <summary>
    /// EVSE is currently occupied, another session is ongoing. Cannot start a new session
    /// </summary>
    [EnumMember(Value = "EVSE_OCCUPIED")]
    EvseOccupied = 31,

    /// <summary>
    /// EVSE is currently inoperative or faulted.
    /// </summary>
    [EnumMember(Value = "EVSE_INOPERATIVE")]
    EvseInoperative = 32,

    //======================================

    /// <summary>
    /// Execution of the command failed at the Charge Point.
    /// </summary>
    [EnumMember(Value = "FAILED")]
    Failed = 41,

    /// <summary>
    /// The requested command is not supported by this Charge Point, EVSE etc.
    /// </summary>
    [EnumMember(Value = "NOT_SUPPORTED")]
    NotSupported = 42,

    /// <summary>
    /// Command request rejected by the Charge Point.
    /// </summary>
    [EnumMember(Value = "REJECTED")]
    Rejected = 43,

    /// <summary>
    /// Command request timeout, no response received from the Charge Point in a reasonable time.
    /// </summary>
    [EnumMember(Value = "TIMEOUT")]
    Timeout = 44
}
