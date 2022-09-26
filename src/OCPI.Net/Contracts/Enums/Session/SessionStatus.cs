using System.Runtime.Serialization;

namespace OCPI.Contracts
{
    public enum SessionStatus : byte
    {
        /// <summary>
        /// The session is started due to a reservation, charging has not yet started. The session might never
        ///become an active session.
        /// </summary>
        [EnumMember(Value = "RESERVATION")]
        Reservation = 11,

        /// <summary>
        /// The session is pending, it has not yet started. Not all pre-conditions are met. This is the initial state.
        /// The session might never become an active session.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending = 12,

        //======================================

        /// <summary>
        /// The session has been accepted and is active. All pre-conditions were met: Communication
        /// between EV and EVSE (for example: cable plugged in correctly), EV or driver is authorized. EV is
        /// being charged, or can be charged. Energy is, or is not, being transfered.
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        Active = 21,

        //======================================

        /// <summary>
        /// The session has been finished successfully. No more modifications will be made to the Session
        /// object using this state.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed = 31,

        //======================================

        /// <summary>
        /// The Session object using this state is declared invalid and will not be billed.
        /// </summary>
        [EnumMember(Value = "INVALID")]
        Invalid = 41
    }
}
