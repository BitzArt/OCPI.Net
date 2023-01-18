using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class SignedDataViewModel
{
    [JsonPropertyName("encoding_method")]
    public string? EncodingMethod { get; set; }

    [JsonPropertyName("encoding_method_version")]
    public int? EncodingMethodVersion { get; set; }

    [JsonPropertyName("public_key")]
    public string? PublicKey { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("signed_values")]
    public IEnumerable<SignedValueViewModel>? SignedValues { get; set; }
}
