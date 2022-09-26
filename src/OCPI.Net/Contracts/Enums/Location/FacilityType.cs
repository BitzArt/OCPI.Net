using System.Runtime.Serialization;

namespace OCPI;

public enum FacilityType : byte
{
    /// <summary>A hotel.</summary>
    [EnumMember(Value = "HOTEL")]
    Hotel = 1,

    /// <summary>A restaurant.</summary>
    [EnumMember(Value = "RESTAURANT")]
    Restaurant = 2,

    /// <summary>A cafe</summary>
    [EnumMember(Value = "CAFE")]
    Cafe = 3,

    /// <summary>A mall or shopping center.</summary>
    [EnumMember(Value = "MALL")]
    Mall = 4,

    /// <summary>A supermarket.</summary>
    [EnumMember(Value = "SUPERMARKET")]
    Supermarket = 5,

    //======================================

    /// <summary>Sport facilities: gym, field etc</summary>
    [EnumMember(Value = "SPORT")]
    Sport = 11,

    /// <summary>A recreation area.</summary>
    [EnumMember(Value = "RECREATION_AREA")]
    RecreationArea = 12,

    /// <summary>Located in, or close to, a park, nature reserve etc.</summary>
    [EnumMember(Value = "NATURE")]
    Nature = 13,

    /// <summary>A museum.</summary>
    [EnumMember(Value = "MUSEUM")]
    Museum = 14,

    //======================================

    /// <summary>A bike/e-bike/e-scooter sharing location.</summary>
    [EnumMember(Value = "BIKE_SHARING")]
    BikeSharing = 21,

    /// <summary>A bus stop.</summary>
    [EnumMember(Value = "BUS_STOP")]
    BusStop = 22,

    /// <summary>A taxi stand.</summary>
    [EnumMember(Value = "TAXI_STAND")]
    TaxiStand = 23,

    /// <summary>A tram stop/station.</summary>
    [EnumMember(Value = "TRAM_STOP")]
    TramStop = 24,

    /// <summary>A metro station.</summary>
    [EnumMember(Value = "METRO_STATION")]
    MetroStation = 25,

    /// <summary>A train station.</summary>
    [EnumMember(Value = "TRAIN_STATION")]
    TrainStation = 26,

    /// <summary>An airport.</summary>
    [EnumMember(Value = "AIRPORT")]
    Airport = 27,

    /// <summary>A parking lot.</summary>
    [EnumMember(Value = "PARKING_LOT")]
    ParkingLot = 28,

    /// <summary>A carpool parking.</summary>
    [EnumMember(Value = "CARPOOL_PARKING")]
    CarpoolParking = 29,

    //======================================

    /// <summary>A Fuel station.</summary>
    [EnumMember(Value = "FUEL_STATION")]
    FuelStation = 31,

    //======================================

    /// <summary>Wifi or other type of internet available.</summary>
    [EnumMember(Value = "WIFI")]
    Wifi = 41
}
