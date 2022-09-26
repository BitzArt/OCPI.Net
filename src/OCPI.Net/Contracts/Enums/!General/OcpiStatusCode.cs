using System.Runtime.Serialization;

namespace OCPI;

public enum OcpiStatusCode : int
{
    //====================1xxx: Success========================

    /// <summary>
    /// Generic success code
    /// </summary>
    [EnumMember(Value = "Success")]
    Success = 1000,

    //=================2xxx: Client errors=====================

    /// <summary>
    /// Generic client error
    /// </summary>
    [EnumMember(Value = "Client error")]
    ClientError = 2000,

    /// <summary>
    /// Invalid or missing parameters, for example:
    /// missing last_updated field in a PATCH request.
    /// </summary>
    [EnumMember(Value = "Invalid parameters")]
    InvalidParameters = 2001,

    /// <summary>
    /// Not enough information, for example:
    /// Authorization request with too little information.
    /// </summary>
    [EnumMember(Value = "Not enough information")]
    NotEnoughInformation = 2002,

    /// <summary>
    /// Unknown Location, for example:
    /// Command: START_SESSION with unknown location.
    /// </summary>
    [EnumMember(Value = "Unknown location")]
    UnknownLocation = 2003,

    /// <summary>
    /// Unknown Token, for example:
    /// 'real-time' authorization of an unknown Token.
    /// </summary>
    [EnumMember(Value = "Unknown token")]
    UnknownToken = 2004,

    //=================3xxx: Server errors=====================

    /// <summary>
    /// Generic server error
    /// </summary>
    [EnumMember(Value = "Server error")]
    ServerError = 3000,

    /// <summary>
    /// Unable to use the client’s API.
    /// For example during the credentials registration:
    /// When the initializing party requests data from the other party
    /// during the open POST call to its credentials endpoint.
    /// If one of the GETs can not be processed,
    /// the party should return this error in the POST response.
    /// </summary>
    [EnumMember(Value = "Client api error")]
    ClientApiError = 3001,

    /// <summary>
    /// Unsupported version
    /// </summary>
    [EnumMember(Value = "Unsupported version")]
    UnsupportedVersion = 3002,

    /// <summary>
    /// No matching endpoints or expected endpoints missing between parties.
    /// Used during the registration process if the two parties do not have
    /// any mutual modules or endpoints available,
    /// or the minimal implementation expected by the other party is not been met.
    /// </summary>
    [EnumMember(Value = "Missing endpoint")]
    MissingEndpoint = 3003,

    //=================4xxx: Hub errors=====================

    /// <summary>
    /// Generic Hub error
    /// </summary>
    [EnumMember(Value = "Hub error")]
    HubError = 4000,

    /// <summary>
    /// Unknown receiver (TO address is unknown)
    /// </summary>
    [EnumMember(Value = "Unknown receiver")]
    UnknownReceiver = 4001,

    /// <summary>
    /// Timeout on forwarded request
    /// (message is forwarded, but request times out)
    /// </summary>
    [EnumMember(Value = "Timeout on forwarded request")]
    TimeoutOnForwardedRequest = 4002,

    /// <summary>
    /// Connection problem (receiving party is not connected)
    /// </summary>
    [EnumMember(Value = "Connection problem")]
    ConnectionProblem = 4003,
}
