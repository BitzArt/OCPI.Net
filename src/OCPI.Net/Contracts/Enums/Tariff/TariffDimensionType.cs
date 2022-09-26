using System.Runtime.Serialization;

namespace OCPI.Contracts
{
    public enum TariffDimensionType : byte
    {
        [EnumMember(Value = "ENERGY")]
        Energy = 11,

        //======================================

        [EnumMember(Value = "FLAT")]
        Flat = 21,

        //======================================

        [EnumMember(Value = "PARKING_TIME")]
        ParkingTime = 31,

        [EnumMember(Value = "TIME")]
        Time = 32
    }
}
