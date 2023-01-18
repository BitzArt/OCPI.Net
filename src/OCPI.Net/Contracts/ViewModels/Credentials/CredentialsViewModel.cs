using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class CredentialsViewModel
{
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("roles")]
    public IEnumerable<CredentialsRoleViewModel>? Roles { get; set; }
}
