using System.Runtime.Serialization;

namespace OCPI.Contracts
{
    public enum OcpiDayOfWeek : byte
    {
        [EnumMember(Value = "MONDAY")]
        Monday = 1,

        [EnumMember(Value = "TUESDAY")]
        Tuesday = 2,

        [EnumMember(Value = "WEDNESDAY")]
        Wednesday = 3,

        [EnumMember(Value = "THURSDAY")]
        Thursday = 4,

        [EnumMember(Value = "FRIDAY")]
        Friday = 5,

        [EnumMember(Value = "SATURDAY")]
        Saturday = 6,

        [EnumMember(Value = "SUNDAY")]
        Sunday = 7
    }
}
