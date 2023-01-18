using System.Runtime.Serialization;

namespace OCPI;

public enum ReservationRestrictionType : byte
{
    [EnumMember(Value = "RESERVATION")]
    Reservation = 1,

    [EnumMember(Value = "RESERVATION_EXPIRES")]
    ReservationExpires = 2,
}
