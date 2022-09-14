using System.Runtime.Serialization;

namespace OCPI
{
    public enum ParkingType : byte
    {
        [EnumMember(Value = "ALONG_MOTORWAY")]
        AlongMotorway = 11,

        [EnumMember(Value = "ON_DRIVEWAY")]
        OnDriveway = 12,

        [EnumMember(Value = "ON_STREET")]
        OnStreet = 13,

        //======================================

        [EnumMember(Value = "PARKING_GARAGE")]
        ParkingGarage = 21,

        [EnumMember(Value = "PARKING_LOT")]
        ParkingLot = 22,

        [EnumMember(Value = "UNDERGROUND_GARAGE")]
        UndergroundGarage = 23
    }
}
