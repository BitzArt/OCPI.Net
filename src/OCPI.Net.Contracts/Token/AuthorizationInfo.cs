using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class AuthorizationInfo
{
    /// <summary>
    /// Status of the Token, and whether charging is allowed at the optionally
    /// given location.
    /// </summary>
    [JsonPropertyName("allowed")]
    public AllowedType Allowed { get; set; }

    /// <summary>
    /// The complete Token object for which this authorization was requested.
    /// </summary>
    [JsonPropertyName("token")]
    public OcpiToken Token { get; set; }

    /// <summary>
    /// Optional reference to the location if it was included in the request, and if
    /// the EV driver is allowed to charge at that location.Only the EVSEs the
    /// EV driver is allowed to charge at are returned.
    /// </summary>
    [JsonPropertyName("location")]
    public LocationReferences? LocationReferences { get; set; }

    /// <summary>
    /// Reference to the authorization given by the eMSP, when given, this
    /// reference will be provided in the relevant Session and/or CDR.
    /// </summary>
    [JsonPropertyName("authorization_reference")]
    public string? AuthorizationReference { get; set; }

    /// <summary>
    /// Optional display text, additional information to the EV driver.
    /// </summary>
    [JsonPropertyName("info")]
    public OcpiDisplayText? Info { get; set; }
}
