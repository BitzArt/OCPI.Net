using System.Runtime.Serialization;

namespace OCPI;

[OcpiDeprecated(after: "2.1.1")]
public enum LocationType : byte
{
    /// <summary>
    ///  Parking location type is not known by the operator (default).
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown = 0,

    //======================================

    /// <summary>
    /// Parking in public space.
    /// </summary>
    [EnumMember(Value = "ON_STREET")]
    OnStreet = 11,

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
    UndergroundGarage = 23,

    //======================================

    /// <summary>
    /// None of the given possibilities.
    /// </summary>
    [EnumMember(Value = "OTHER")]
    Other = 255,
}
