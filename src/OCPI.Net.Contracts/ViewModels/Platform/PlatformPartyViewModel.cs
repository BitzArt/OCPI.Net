﻿using System.Text.Json.Serialization;

namespace OCPI.Contracts
{
    public class PlatformPartyViewModel
    {
        [JsonPropertyName("role")]
        public PartyRole? Role { get; set; }

        [JsonPropertyName("business_details")]
        public BusinessDetailsViewModel? BusinessDetails { get; set; }

        [JsonPropertyName("party_id")]
        public string? PartyId { get; set; }

        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }
    }
}
