using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiEvse
{
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("evse_id")]
    public string? EvseId { get; set; }

    [JsonPropertyName("status")]
    public EvseStatus? Status { get; set; }

    [JsonPropertyName("status_schedule")]
    public IEnumerable<OcpiStatusSchedule>? StatusSchedule { get; set; }

    [JsonPropertyName("capabilities")]
    public IEnumerable<EvseCapabilityType>? Capabilities { get; set; }

    [JsonPropertyName("connectors")]
    public IEnumerable<OcpiConnector>? Connectors { get; set; }

    [JsonPropertyName("floor_level")]
    public string? FloorLevel { get; set; }

    [JsonPropertyName("coordinates")]
    public OcpiGeolocation? Coordinates { get; set; }

    [JsonPropertyName("physical_reference")]
    public string? PhysicalReference { get; set; }

    [JsonPropertyName("directions")]
    public IEnumerable<OcpiDisplayText>? Directions { get; set; }

    [JsonPropertyName("parking_restrictions")]
    public IEnumerable<ParkingRestrictionType>? ParkingRestrictions { get; set; }

    [JsonPropertyName("images")]
    public IEnumerable<OcpiImage>? Images { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }
}
