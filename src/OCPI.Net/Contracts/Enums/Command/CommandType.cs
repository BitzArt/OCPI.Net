using System.Runtime.Serialization;

namespace OCPI.Contracts
{
    public enum CommandType : byte
    {
        /// <summary>
        /// Request the Charge Point to start a transaction on the given EVSE/Connector.
        /// </summary>
        [EnumMember(Value = "START_SESSION")]
        StartSession = 11,

        /// <summary>
        /// Request the Charge Point to stop an ongoing session.
        /// </summary>
        [EnumMember(Value = "STOP_SESSION")]
        StopSession = 12,

        //======================================

        /// <summary>
        /// Request the Charge Point to reserve a (specific) EVSE for a Token for a certain time, starting now.
        /// </summary>
        [EnumMember(Value = " RESERVE_NOW")]
        ReserveNow = 21,

        /// <summary>
        /// Request the Charge Point to cancel a specific reservation.
        /// </summary>
        [EnumMember(Value = "CANCEL_RESERVATION")]
        CancelReservation = 22,

        //======================================

        /// <summary>
        /// Request the Charge Point to unlock the connector (if applicable). This functionality is for help desk operators only!
        /// </summary>
        [EnumMember(Value = "UNLOCK_CONNECTOR")]
        UnlockConnector = 31
    }
}
