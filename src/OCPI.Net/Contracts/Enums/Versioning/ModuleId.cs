using System.Runtime.Serialization;

namespace OCPI;

public enum ModuleId
{
    [EnumMember(Value = "unknown")]
    Unknown,

    [EnumMember(Value = "cdrs")]
    CDRs,

    [EnumMember(Value = "chargingprofiles")]
    ChargingProfiles,

    [EnumMember(Value = "commands")]
    Commands,

    [EnumMember(Value = "credentials")]
    Credentials,

    [EnumMember(Value = "hubclientinfo")]
    HubClientInfo,

    [EnumMember(Value = "locations")]
    Locations,

    [EnumMember(Value = "sessions")]
    Sessions,

    [EnumMember(Value = "tariffs")]
    Tariffs,

    [EnumMember(Value = "tokens")]
    Tokens,

    [EnumMember(Value = "versions")]
    Versions
}
