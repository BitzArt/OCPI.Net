﻿using System.Text.Json.Serialization;

namespace OCPI.Contracts.ChargingProfiles;

public class OcpiChargingProfilePeriod
{
    /// <summary>
    /// Start of the period, in seconds from the start of profile. The value of StartPeriod
    /// also defines the stop time of the previous period.
    /// </summary>
    [JsonPropertyName("start_period")]
    public int? StartPeriod { get; set; }

    /// <summary>
    /// Charging rate limit during the profile period, in the applicable chargingRateUnit,
    /// for example in Amperes(A) or Watts(W). Accepts at most one digit fraction.
    /// </summary>
    [JsonPropertyName("limit")]
    public decimal? Limit { get; set; }

    public override string ToString() => $"Start Period: {StartPeriod}, Limit: {Limit}";
}
