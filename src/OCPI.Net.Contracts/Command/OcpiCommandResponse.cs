using System.Diagnostics.Metrics;
using System.Text.Json.Serialization;
using System.Threading;

namespace OCPI.Contracts;

public class OcpiCommandResponse
{
    /// <summary>
    /// Response from the CPO on the command request.
    /// </summary>
    [JsonPropertyName("result")]
    public CommandResponseType? Result { get; set; }

    /// <summary>
    /// Timeout for this command in seconds.
    /// When the Result is not received within this timeout,
    /// the eMSP can assume that the message might never be send.
    /// </summary>
    [JsonPropertyName("timeout")]
    public int? Timeout { get; set; }

    /// <summary>
    /// Human-readable description of the result (if one can be provided),
    /// multiple languages can be provided.
    /// </summary>
    [JsonPropertyName("message")]
    public IEnumerable<OcpiDisplayText>? Message { get; set; }
}
