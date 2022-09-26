using System.Runtime.Serialization;

namespace OCPI.Contracts
{
    public enum ParkingRestrictionType : byte
    {
        /// <summary>
        /// Reserved parking spot for electric vehicles.
        /// </summary>
        [EnumMember(Value = "EV_ONLY")]
        EvOnly = 11,

        //======================================

        /// <summary>
        /// Parking is only allowed while plugged in (charging).
        /// </summary>
        [EnumMember(Value = "PLUGGED")]
        Plugged = 21,

        /// <summary>
        /// Reserved parking spot for disabled people with valid ID.
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        Disabled = 22,

        /// <summary>
        /// Parking spot only suitable for (electric) motorcycles or scooters.
        /// </summary>
        [EnumMember(Value = "MOTORCYCLES")]
        Motorcycles = 23,

        //======================================

        /// <summary>
        /// Parking spot for customers/guests only,
        /// for example in case of a hotel or shop.
        /// </summary>
        [EnumMember(Value = "CUSTOMERS")]
        Customers = 31
    }
}
