﻿using System.Runtime.Serialization;

namespace OCPI;

public enum CdrDimensionType : byte
{
    //====================1x: Energy========================

    /// <summary>
    /// Total amount of energy (dis-)charged during this ChargingPeriod: defined in kWh.
    /// When negative, more energy was feed into the grid then charged into the EV.
    /// Default step_size is 1.
    /// </summary>
    [EnumMember(Value = "ENERGY")]
    Energy = 11,

    /// <summary>
    /// Total amount of energy feed back into the grid: defined in kWh.
    /// </summary>
    [EnumMember(Value = "ENERGY_EXPORT")]
    EnergyExport = 12,

    /// <summary>
    /// Total amount of energy charged, defined in kWh.
    /// </summary>
    [EnumMember(Value = "ENERGY_IMPORT")]
    EnergyImport = 13,

    //====================2x: Current========================

    /// <summary>
    /// Average charging current during this ChargingPeriod: defined in A (Ampere).
    /// When negative, the current is flowing from the EV to the grid.
    /// </summary>
    [EnumMember(Value = "CURRENT")]
    Current = 21,

    /// <summary>
    /// Sum of the maximum current over all phases, reached during this ChargingPeriod:
    /// defined in A (Ampere).
    /// </summary>
    [EnumMember(Value = "MAX_CURRENT")]
    MaxCurrent = 22,

    /// <summary>
    /// Sum of the minimum current over all phases, reached during this ChargingPeriod,
    /// when negative, current has flowed from the EV to the grid.
    /// Defined in A (Ampere).
    /// </summary>
    [EnumMember(Value = "MIN_CURRENT")]
    MinCurrent = 23,

    //====================3x: Power========================

    /// <summary>
    /// Average power during this ChargingPeriod: defined in kW (Kilowatt).
    /// When negative, the power is flowing from the EV to the grid.
    /// </summary>
    [EnumMember(Value = "POWER")]
    Power = 31,

    /// <summary>
    /// Maximum power reached during this ChargingPeriod: defined in kW (Kilowatt).
    /// </summary>
    [EnumMember(Value = "MAX_POWER")]
    MaxPower = 32,

    /// <summary>
    /// Minimum power reached during this ChargingPeriod: defined in kW (Kilowatt),
    /// when negative, the power has flowed from the EV to the grid.
    /// </summary>
    [EnumMember(Value = "MIN_POWER")]
    MinPower = 33,

    //====================4x: Time========================

    /// <summary>
    /// Time charging during this ChargingPeriod: defined in hours,
    /// default step_size multiplier is 1 second.
    /// </summary>
    [EnumMember(Value = "TIME")]
    Time = 41,

    /// <summary>
    /// Time during this ChargingPeriod not charging: defined in hours,
    /// default step_size multiplier is 1 second.
    /// </summary>
    [EnumMember(Value = "PARKING_TIME")]
    ParkingTime = 42,

    /// <summary>
    /// Time during this ChargingPeriod Charge Point has been reserved
    /// and not yet been in use for this customer: defined in hours,
    /// default step_size multiplier is 1 second.
    /// </summary>
    [EnumMember(Value = "RESERVATION_TIME")]
    ReservationTime = 43,

    //====================5x: Other========================

    /// <summary>
    /// Current state of charge of the EV, in percentage,
    /// values allowed: 0 to 100.
    /// </summary>
    [EnumMember(Value = "STATE_OF_CHARGE")]
    StateOfCharge = 51,
}
