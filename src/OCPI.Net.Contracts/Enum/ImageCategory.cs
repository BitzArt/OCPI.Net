using System.Runtime.Serialization;

namespace OCPI
{
    public enum ImageCategory : byte
    {
        [EnumMember(Value = "CHARGER")]
        Charger = 1,

        [EnumMember(Value = "ENTRANCE")]
        Entrance = 2,

        [EnumMember(Value = "LOCATION")]
        Location = 3,

        [EnumMember(Value = "NETWORK")]
        Network = 4,

        //======================================

        [EnumMember(Value = "OPERATOR")]
        Operator = 11,

        [EnumMember(Value = "OWNER")]
        Owner = 12,

        //======================================

        [EnumMember(Value = "OTHER")]
        Other = 255
    }
}
