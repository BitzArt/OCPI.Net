using System.Text.Json.Serialization;
using OCPI.Enums.SmartCharging;

namespace OCPI.Contracts.ChargingProfiles;
public class OcpiChargingProfileResponse
{
    /// <summary>
    /// Response from the CPO on the ChargingProfile request.
    /// </summary>
    [JsonPropertyName("result")]
    public required ChargingProfileResponseType Result { get; set; }

    /// <summary>
    /// Response from the CPO on the ChargingProfile request.
    /// </summary>
    [JsonPropertyName("timeout")]
    public required int Timeout { get; set; }
}
