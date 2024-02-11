using System.Text.Json.Serialization;
using OCPI.Enums.ChargingProfiles;

namespace OCPI.Contracts.ChargingProfiles;
public class OcpiChargingProfileResult
{
    /// <summary>
    /// The EVSE will indicate if it was able to process the new/updated charging
    /// profile.
    /// </summary>
    [JsonPropertyName("result")]
    public ChargingProfileResultType? Result { get; set; }
}
