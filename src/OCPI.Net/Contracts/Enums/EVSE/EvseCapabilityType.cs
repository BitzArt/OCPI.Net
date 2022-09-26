using System.Runtime.Serialization;

namespace OCPI.Contracts
{
    public enum EvseCapabilityType : byte
    {
        [EnumMember(Value = "CHARGING_PROFILE_CAPABLE")]
        ChargingProfileCapable = 11,

        [EnumMember(Value = "CHARGING_PREFERENCES_CAPABLE")]
        ChargingPreferencesCapable = 12,

        [EnumMember(Value = "RESERVABLE")]
        Reservable = 13,

        [EnumMember(Value = "REMOTE_START_STOP_CAPABLE")]
        RemoteStartStopCapable = 14,

        [EnumMember(Value = "UNLOCK_CAPABLE")]
        UnlockCapable = 15,

        [EnumMember(Value = "TOKEN_GROUP_CAPABLE")]
        TokenGroupCapable = 16,

        //======================================

        [EnumMember(Value = "CHIP_CARD_SUPPORT")]
        ChipCardSupport = 21,

        [EnumMember(Value = "CONTACTLESS_CARD_SUPPORT")]
        ContactlessCardSupport = 22,

        [EnumMember(Value = "PED_TERMINAL")]
        PedTerminal = 23,

        [EnumMember(Value = "RFID_READER")]
        RfidReader = 24,

        //======================================

        [EnumMember(Value = "CREDIT_CARD_PAYABLE")]
        CreditCardPayable = 31,

        [EnumMember(Value = "DEBIT_CARD_PAYABLE")]
        DebitCardPayable = 32,

        //======================================

        [EnumMember(Value = "START_SESSION_CONNECTOR_REQUIRED")]
        StartSessionConnectorRequired = 41
    }
}
