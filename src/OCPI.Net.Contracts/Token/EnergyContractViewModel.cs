using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class EnergyContractViewModel
{
    [JsonPropertyName("supplier_name")]
    public string? SupplierName { get; set; }

    [JsonPropertyName("contract_id")]
    public string? ContractId { get; set; }
}
