using System.Runtime.Serialization;

namespace OCPI;

public enum ConnectorType : byte
{
    /// <summary>
    /// The connector type is CHAdeMO, DC
    /// </summary>
    [EnumMember(Value = "CHADEMO")]
    Chademo = 11,

    /// <summary>
    /// The ChaoJi connector.
    /// The new generation charging connector, harmonized between CHAdeMO and GB/T. DC.
    /// </summary>
    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "CHAOJI")]
    CHAOJI = 12,

    //======================================

    /// <summary>
    /// IEC 60309-2 Industrial Connector single phase 16 amperes (usually blue)
    /// </summary>
    [EnumMember(Value = "IEC_60309_2_single_16")]
    IEC_60309_2_Single_16 = 21,

    /// <summary>
    /// IEC 60309-2 Industrial Connector three phase 16 amperes (usually red)
    /// </summary>
    [EnumMember(Value = "IEC_60309_2_three_16")]
    IEC_60309_2_Three_16 = 22,

    /// <summary>
    /// IEC 60309-2 Industrial Connector three phase 32 amperes (usually red)
    /// </summary>
    [EnumMember(Value = "IEC_60309_2_three_32")]
    IEC_60309_2_Three_32 = 23,

    /// <summary>
    /// IEC 60309-2 Industrial Connector three phase 64 amperes (usually red)
    /// </summary>
    [EnumMember(Value = "IEC_60309_2_three_64")]
    IEC_60309_2_Three_64 = 24,

    //======================================

    /// <summary>
    /// IEC 62196 Type 1 "SAE J1772"
    /// </summary>
    [EnumMember(Value = "IEC_62196_T1")]
    IEC_62196_T1 = 31,

    /// <summary>
    /// Combo Type 1 based, DC
    /// </summary>
    [EnumMember(Value = "IEC_62196_T1_COMBO")]
    IEC_62196_T1_Combo = 32,

    /// <summary>
    /// IEC 62196 Type 2 "Mennekes"
    /// </summary>
    [EnumMember(Value = "IEC_62196_T2")]
    IEC_62196_T2 = 33,

    /// <summary>
    /// Combo Type 2 based, DC
    /// </summary>
    [EnumMember(Value = "IEC_62196_T2_COMBO")]
    IEC_62196_T2_Combo = 34,

    /// <summary>
    /// IEC 62196 Type 3A
    /// </summary>
    [EnumMember(Value = "IEC_62196_T3A")]
    IEC_62196_T3A = 35,

    /// <summary>
    /// IEC 62196 Type 3C "Scame"
    /// </summary>
    [EnumMember(Value = "IEC_62196_T3C")]
    IEC_62196_T3C = 36,

    //======================================

    /// <summary>
    /// On-board Bottom-up-Pantograph typically for bus charging
    /// </summary>
    [EnumMember(Value = "PANTOGRAPH_BOTTOM_UP")]
    PantographBottomUp = 41,

    /// <summary>
    /// Off-board Top-down-Pantograph typically for bus charging
    /// </summary>
    [EnumMember(Value = "PANTOGRAPH_TOP_DOWN")]
    PantographTopDown = 42,

    //======================================

    /// <summary>
    /// Tesla Connector "Roadster"-type (round, 4 pin)
    /// </summary>
    [EnumMember(Value = "TESLA_R")]
    Tesla_R = 51,

    /// <summary>
    /// Tesla Connector "Model-S"-type (oval, 5 pin)
    /// </summary>
    [EnumMember(Value = "TESLA_S")]
    Tesla_S = 52,

    //======================================

    /// <summary>
    /// Standard/Domestic household, type "A", NEMA 1-15, 2 pins
    /// </summary>
    [EnumMember(Value = "DOMESTIC_A")]
    Domestic_A = 101,

    /// <summary>
    /// Standard/Domestic household, type "B", NEMA 5-15, 3 pins
    /// </summary>
    [EnumMember(Value = "DOMESTIC_B")]
    Domestic_B = 102,

    /// <summary>
    /// Standard/Domestic household, type "C", CEE 7/17, 2 pins
    /// </summary>
    [EnumMember(Value = "DOMESTIC_C")]
    Domestic_C = 103,

    /// <summary>
    /// Standard/Domestic household, type "D", 3 pin
    /// </summary>
    [EnumMember(Value = "DOMESTIC_D")]
    Domestic_D = 104,

    /// <summary>
    /// Standard/Domestic household, type "E", CEE 7/5 3 pins
    /// </summary>
    [EnumMember(Value = "DOMESTIC_E")]
    Domestic_E = 105,

    /// <summary>
    /// Standard/Domestic household, type "F", CEE 7/4, Schuko, 3 pins
    /// </summary>
    [EnumMember(Value = "DOMESTIC_F")]
    Domestic_F = 106,

    /// <summary>
    /// Standard/Domestic household, type "G", BS 1363, Commonwealth, 3 pins
    /// </summary>
    [EnumMember(Value = "DOMESTIC_G")]
    Domestic_G = 107,

    /// <summary>
    /// Standard/Domestic household, type "H", SI-32, 3 pins
    /// </summary>
    [EnumMember(Value = "DOMESTIC_H")]
    Domestic_H = 108,

    /// <summary>
    /// Standard/Domestic household, type "I", AS 3112, 3 pins
    /// </summary>
    [EnumMember(Value = "DOMESTIC_I")]
    Domestic_I = 109,

    /// <summary>
    /// Standard/Domestic household, type "J", SEV 1011, 3 pins
    /// </summary>
    [EnumMember(Value = "DOMESTIC_J")]
    Domestic_J = 110,

    /// <summary>
    /// Standard/Domestic household, type "K", DS 60884-2-D1, 3 pins
    /// </summary>
    [EnumMember(Value = "DOMESTIC_K")]
    Domestic_K = 111,

    /// <summary>
    /// Standard/Domestic household, type "L", CEI 23-16-VII, 3 pins
    /// </summary>
    [EnumMember(Value = "DOMESTIC_L")]
    Domestic_L = 112,

    /// <summary>
    /// Standard/Domestic household, type "M", BS 546, 3 pins
    /// </summary>
    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "Domestic_M")]
    Domestic_M = 113,

    /// <summary>
    /// Standard/Domestic household, type "N", NBR 14136, 3 pins
    /// </summary>
    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "Domestic_N")]
    Domestic_N = 114,

    /// <summary>
    /// Standard/Domestic household, type "O", TIS 166-2549, 3 pins
    /// </summary>
    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "Domestic_O")]
    Domestic_O = 115,

    /// <summary>
    /// Guobiao GB/T 20234.2 AC socket/connector
    /// </summary>IEC_62196_T2
    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "GBT_AC")]
    GBT_AC = 117,

    /// <summary>
    /// Guobiao GB/T 20234.3 DC connector
    /// </summary>
    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "GBT_DC")]
    GBT_DC = 118,

    //======================================

    /// <summary>
    /// NEMA 5-20, 3 pins
    /// </summary>
    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "NEMA_5_20")]
    NEMA_5_20 = 131,

    /// <summary>
    /// NEMA 6-30, 3 pins
    /// </summary>
    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "NEMA_6_30")]
    NEMA_6_30 = 132,

    /// <summary>
    /// NEMA 6-50, 3 pins
    /// </summary>
    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "NEMA_6_50")]
    NEMA_6_50 = 133,

    /// <summary>
    /// NEMA 10-30, 3 pins
    /// </summary>
    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "NEMA_10_30")]
    NEMA_10_30 = 134,

    // <summary>
    /// NEMA 10-50, 3 pins
    /// </summary>
    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "NEMA_10_50")]
    NEMA_10_50 = 135,

    // <summary>
    /// NEMA 14-30, 3 pins, rating of 30 A
    /// </summary>
    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "NEMA_14_30")]
    NEMA_14_30 = 136,

    // <summary>
    /// NEMA 14-50, 3 pins, rating of 50 A
    /// </summary>
    [OcpiIntroduced("2.2.1")]
    [EnumMember(Value = "NEMA_14_50")]
    NEMA_14_50 = 137
}
