using System.Runtime.Serialization;

namespace OCPI;

public enum ParkingType : byte
{
    /// <summary>
    /// Location on a parking facility/rest area along
    /// a motorway, freeway, interstate, highway etc.
    /// </summary>
    [EnumMember(Value = "ALONG_MOTORWAY")]
    AlongMotorway = 11,

    /// <summary>
    /// Location is on the driveway of a house/building.
    /// </summary>
    [EnumMember(Value = "ON_DRIVEWAY")]
    OnDriveway = 12,

    /// <summary>
    /// Parking in public space along a street.
    /// </summary>
    [EnumMember(Value = "ON_STREET")]
    OnStreet = 13,

    //======================================

    /// <summary>
    /// Multistorey car park
    /// </summary>
    [EnumMember(Value = "PARKING_GARAGE")]
    ParkingGarage = 21,

    /// <summary>
    /// A cleared area that is intended for parking vehicles,
    /// i.e. at super markets, bars, etc.
    /// </summary>
    [EnumMember(Value = "PARKING_LOT")]
    ParkingLot = 22,

    /// <summary>
    /// Multistorey car park, mainly underground.
    /// </summary>
    [EnumMember(Value = "UNDERGROUND_GARAGE")]
    UndergroundGarage = 23
}
