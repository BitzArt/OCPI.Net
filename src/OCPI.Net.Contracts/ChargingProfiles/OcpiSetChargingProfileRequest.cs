using System.Text.Json.Serialization;

namespace OCPI.Contracts.ChargingProfiles;
public class OcpiSetChargingProfileRequest
{
    /// <summary>
    /// Contains limits for the available power or current over time.
    /// </summary>
    [JsonPropertyName("charging_profile")]
    public OcpiChargingProfile? ChargingProfile { get; set; }

    /// <summary>
    /// URL that the ChargingProfileResult POST should be send to. This
    /// URL might contain an unique ID to be able to distinguish between
    /// GET ActiveChargingProfile requests.
    /// </summary>
    [JsonPropertyName("response_url")]
    public string? ResponseUrl { get; set; }
}
