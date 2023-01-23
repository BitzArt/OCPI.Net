using System.Runtime.Serialization;

namespace OCPI;

public enum TariffType : byte
{
    [EnumMember(Value = "REGULAR")]
    Regular = 11,

    //======================================

    [EnumMember(Value = "AD_HOC_PAYMENT")]
    AdHocPayment = 21,

    //======================================

    [EnumMember(Value = "PROFILE_CHEAP")]
    ProfileCheap = 31,

    [EnumMember(Value = "PROFILE_FAST")]
    ProfileFast = 32,

    [EnumMember(Value = "PROFILE_GREEN")]
    ProfileGreen = 33
}
