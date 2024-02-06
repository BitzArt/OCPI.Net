using System.Text.Json.Serialization;

namespace OCPI.Contracts.ChargingProfiles;
public class SetChargingProfile
{
    /// <summary>
    /// Contains limits for the available power or current over time.
    /// </summary>
    [JsonPropertyName("charging_profile")]
    public required ChargingProfile ChargingProfile { get; set; } = null!;

    /// <summary>
    /// URL that the ChargingProfileResult POST should be send to. This
    /// URL might contain an unique ID to be able to distinguish between
    /// GET ActiveChargingProfile requests.
    /// </summary>
    [JsonPropertyName("response_url")]
    public required string ResponseUrl { get; set; } = null!;
}