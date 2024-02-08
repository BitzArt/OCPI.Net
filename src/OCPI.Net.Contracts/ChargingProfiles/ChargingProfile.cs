﻿using System.Collections.Immutable;
using System.Text;
using System.Text.Json.Serialization;
using OCPI.Enums.SmartCharging;

namespace OCPI.Contracts.ChargingProfiles;

public class ChargingProfile
{
    /// <summary>
    /// Starting point of an absolute profile. If absent the profile
    /// will be relative to start of charging.
    /// </summary>
    [JsonPropertyName("start_date_time")]
    public DateTime? StartDateTime { get; set; }

    /// <summary>
    /// Duration of the charging profile in seconds. If the
    /// duration is left empty, the last period will continue
    /// indefinitely or until end of the transaction in case
    /// start_date_time is absent.
    /// </summary>
    [JsonPropertyName("duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// The unit of measure.
    /// </summary>
    [JsonPropertyName("charging_rate_unit")]
    public required ChargingRateUnit ChargingRateUnit { get; set; }

    /// <summary>
    /// Minimum charging rate supported by the EV. The unit
    /// of measure is defined by the chargingRateUnit.This
    /// parameter is intended to be used by a local smart
    /// charging algorithm to optimize the power allocation for
    /// in the case a charging process is inefficient at lower
    /// charging rates.Accepts at most one digit fraction.
    /// </summary>
    [JsonPropertyName("min_charging_rate")]
    public decimal? MinChargingRate { get; set; }

    /// <summary>
    /// List of ChargingProfilePeriod elements defining
    /// maximum power or current usage over time.
    /// </summary>
    [JsonPropertyName("charging_profile_period")]
    public IEnumerable<ChargingProfilePeriod>? ChargingProfilePeriod { get; set; }

    public override string ToString()
    {
        var toStringBuilder = new StringBuilder();
        toStringBuilder.Append($"Start date time: {StartDateTime}, ");
        toStringBuilder.AppendLine($"Duration: {Duration},");
        toStringBuilder.Append($"Charging rate unit: {ChargingRateUnit}, ");
        toStringBuilder.AppendLine($"Minimum charging rate: {MinChargingRate},");
        var chargingProfilePeriodToString = ChargingProfilePeriodToString();
        return toStringBuilder.Append(chargingProfilePeriodToString).ToString();
    }

    private string ChargingProfilePeriodToString()
    {
        var toStringBuilder = new StringBuilder();
        toStringBuilder.AppendLine("ChargingProfilePeriods:");

        var periodsToIterate = ChargingProfilePeriod ?? ImmutableList<ChargingProfilePeriod>.Empty;
        var periodNum = 1;
        foreach (var period in periodsToIterate) 
            toStringBuilder.Append($"Period #{periodNum++}: {period}; ");

        return toStringBuilder.ToString();
    }
}
