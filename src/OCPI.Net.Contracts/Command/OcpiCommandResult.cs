using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiCommandResult
{
    /// <summary>
    /// Result of the command request as sent by the Charge Point to the CPO.
    /// </summary>
    [JsonPropertyName("result")]
    public CommandResultType? Result { get; set; }

    /// <summary>
    /// Human-readable description of the reason (if one can be provided),
    /// multiple languages can be provided.
    /// </summary>
    [JsonPropertyName("message")]
    public IEnumerable<OcpiDisplayText>? Message { get; set; }
}
