using System.Runtime.Serialization;

namespace OCPI;

public enum OcpiModule : byte
{
    [EnumMember(Value = "unknown")]
    Unknown = 0,

    //======================================

    [EnumMember(Value = "credentials")]
    Credentials = 11,

    [EnumMember(Value = "versions")]
    Versions = 12,

    //======================================

    [EnumMember(Value = "locations")]
    Locations = 21,

    [EnumMember(Value = "tariffs")]
    Tariffs = 22,

    //======================================

    [EnumMember(Value = "sessions")]
    Sessions = 31,

    [EnumMember(Value = "cdrs")]
    CDRs = 32,

    [EnumMember(Value = "tokens")]
    Tokens = 33,

    //======================================

    [EnumMember(Value = "commands")]
    Commands = 41,

    //======================================

    [EnumMember(Value = "chargingprofiles")]
    ChargingProfiles = 51,

    //======================================

    [EnumMember(Value = "hubclientinfo")]
    HubClientInfo = 61
}
