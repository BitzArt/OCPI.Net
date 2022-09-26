using System.Runtime.Serialization;

namespace OCPI
{
    public enum OcpiStatusCode : int
    {
        [EnumMember(Value = "Success")]
        Success = 1000,

        //======================================

        [EnumMember(Value = "Client error")]
        ClientError = 2000,

        [EnumMember(Value = "Invalid parameters")]
        InvalidParameters = 2001,

        [EnumMember(Value = "Not enough information")]
        NotEnoughInformation = 2002,

        [EnumMember(Value = "Unknown location")]
        UnknownLocation = 2003,

        [EnumMember(Value = "Unknown token")]
        UnknownToken = 2004,

        //======================================

        [EnumMember(Value = "Server error")]
        ServerError = 3000,

        [EnumMember(Value = "Client api error")]
        ClientApiError = 3001,

        [EnumMember(Value = "Unsupported version")]
        UnsupportedVersion = 3002,

        [EnumMember(Value = "Missing endpoint")]
        MissingEndpoint = 3003,
    }
}
