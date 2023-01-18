using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class EvseViewModel
{
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("evse_id")]
    public string? EvseId { get; set; }

    [JsonPropertyName("status")]
    public EvseStatus? Status { get; set; }

    [JsonPropertyName("status_schedule")]
    public IEnumerable<EvsePlannedStatusViewModel>? StatusSchedule { get; set; }

    [JsonPropertyName("capabilities")]
    public IEnumerable<EvseCapabilityType>? Capabilities { get; set; }

    [JsonPropertyName("connectors")]
    public IEnumerable<ConnectorViewModel>? Connectors { get; set; }

    [JsonPropertyName("floor_level")]
    public string? FloorLevel { get; set; }

    [JsonPropertyName("coordinates")]
    public GeolocationViewModel? Coordinates { get; set; }

    [JsonPropertyName("physical_reference")]
    public string? PhysicalReference { get; set; }

    [JsonPropertyName("directions")]
    public IEnumerable<DisplayTextViewModel>? Directions { get; set; }

    [JsonPropertyName("parking_restrictions")]
    public IEnumerable<ParkingRestrictionType>? ParkingRestrictions { get; set; }

    [JsonPropertyName("images")]
    public IEnumerable<ImageViewModel>? Images { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; }
}
