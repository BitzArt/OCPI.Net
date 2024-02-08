using System.Text.Json.Serialization;
using OCPI.Enums.SmartCharging;

namespace OCPI.Contracts.ChargingProfiles;
public class OcpiChargingProfileResponse
{
    /// <summary>
    /// Response from the CPO on the ChargingProfile request.
    /// </summary>
    [JsonPropertyName("result")]
    public ChargingProfileResponseType? Result { get; set; }

    /// <summary>
    /// Response from the CPO on the ChargingProfile request.
    /// </summary>
    [JsonPropertyName("timeout")]
    public int? Timeout { get; set; }
}
