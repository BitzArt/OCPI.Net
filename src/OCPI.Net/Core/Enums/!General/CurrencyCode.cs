using System.Runtime.Serialization;

namespace OCPI;

public enum CurrencyCode
{
    [EnumMember(Value = "AFN")]
    Afghani = 971,

    [EnumMember(Value = "EUR")]
    Euro = 978,

    [EnumMember(Value = "ALL")]
    Lek = 008,

    [EnumMember(Value = "DZD")]
    AlgerianDinar = 012,

    [EnumMember(Value = "USD")]
    USDollar = 840,

    [EnumMember(Value = "AOA")]
    Kwanza = 973,

    [EnumMember(Value = "XCD")]
    EastCaribbeanDollar = 951,

    [EnumMember(Value = "ARS")]
    ArgentinePeso = 032,

    [EnumMember(Value = "AMD")]
    ArmenianDram = 051,

    [EnumMember(Value = "AWG")]
    ArubanFlorin = 533,

    [EnumMember(Value = "AUD")]
    AustralianDollar = 036,

    [EnumMember(Value = "AZN")]
    AzerbaijanManat = 944,

    [EnumMember(Value = "BSD")]
    BahamianDollar = 044,

    [EnumMember(Value = "BHD")]
    BahrainiDinar = 048,

    [EnumMember(Value = "BDT")]
    Taka = 050,

    [EnumMember(Value = "BBD")]
    BarbadosDollar = 052,

    [EnumMember(Value = "BYN")]
    BelarusianRuble = 933,

    [EnumMember(Value = "BZD")]
    BelizeDollar = 084,

    [EnumMember(Value = "XOF")]
    CFAFrancBCEAO = 952,

    [EnumMember(Value = "BMD")]
    BermudianDollar = 060,

    [EnumMember(Value = "INR")]
    IndianRupee = 356,

    [EnumMember(Value = "BTN")]
    Ngultrum = 064,

    [EnumMember(Value = "BOB")]
    Boliviano = 068,

    [EnumMember(Value = "BOV")]
    Mvdol = 984,

    [EnumMember(Value = "BAM")]
    ConvertibleMark = 977,

    [EnumMember(Value = "BWP")]
    Pula = 072,

    [EnumMember(Value = "NOK")]
    NorwegianKrone = 578,

    [EnumMember(Value = "BRL")]
    BrazilianReal = 986,

    [EnumMember(Value = "BND")]
    BruneiDollar = 096,

    [EnumMember(Value = "BGN")]
    BulgarianLev = 975,

    [EnumMember(Value = "BIF")]
    BurundiFranc = 108,

    [EnumMember(Value = "CVE")]
    CaboVerdeEscudo = 132,

    [EnumMember(Value = "KHR")]
    Riel = 116,

    [EnumMember(Value = "XAF")]
    CFAFrancBEAC = 950,

    [EnumMember(Value = "CAD")]
    CanadianDollar = 124,

    [EnumMember(Value = "KYD")]
    CaymanIslandsDollar = 136,

    [EnumMember(Value = "CLP")]
    ChileanPeso = 152,

    [EnumMember(Value = "CLF")]
    UnidaddeFomento = 990,

    [EnumMember(Value = "CNY")]
    YuanRenminbi = 156,

    [EnumMember(Value = "COP")]
    ColombianPeso = 170,

    [EnumMember(Value = "COU")]
    UnidaddeValorReal = 970,

    [EnumMember(Value = "KMF")]
    ComorianFranc = 174,

    [EnumMember(Value = "CDF")]
    CongoleseFranc = 976,

    [EnumMember(Value = "NZD")]
    NewZealandDollar = 554,

    [EnumMember(Value = "CRC")]
    CostaRicanColon = 188,

    [EnumMember(Value = "HRK")]
    Kuna = 191,

    [EnumMember(Value = "CUP")]
    CubanPeso = 192,

    [EnumMember(Value = "CUC")]
    PesoConvertible = 931,

    [EnumMember(Value = "ANG")]
    NetherlandsAntilleanGuilder = 532,

    [EnumMember(Value = "CZK")]
    CzechKoruna = 203,

    [EnumMember(Value = "DKK")]
    DanishKrone = 208,

    [EnumMember(Value = "DJF")]
    DjiboutiFranc = 262,

    [EnumMember(Value = "DOP")]
    DominicanPeso = 214,

    [EnumMember(Value = "EGP")]
    EgyptianPound = 818,

    [EnumMember(Value = "SVC")]
    ElSalvadorColon = 222,

    [EnumMember(Value = "ERN")]
    Nakfa = 232,

    [EnumMember(Value = "SZL")]
    Lilangeni = 748,

    [EnumMember(Value = "ETB")]
    EthiopianBirr = 230,

    [EnumMember(Value = "FKP")]
    FalklandIslandsPound = 238,

    [EnumMember(Value = "FJD")]
    FijiDollar = 242,

    [EnumMember(Value = "XPF")]
    CFPFranc = 953,

    [EnumMember(Value = "GMD")]
    Dalasi = 270,

    [EnumMember(Value = "GEL")]
    Lari = 981,

    [EnumMember(Value = "GHS")]
    GhanaCedi = 936,

    [EnumMember(Value = "GIP")]
    GibraltarPound = 292,

    [EnumMember(Value = "GTQ")]
    Quetzal = 320,

    [EnumMember(Value = "GBP")]
    PoundSterling = 826,

    [EnumMember(Value = "GNF")]
    GuineanFranc = 324,

    [EnumMember(Value = "GYD")]
    GuyanaDollar = 328,

    [EnumMember(Value = "HTG")]
    Gourde = 332,

    [EnumMember(Value = "HNL")]
    Lempira = 340,

    [EnumMember(Value = "HKD")]
    HongKongDollar = 344,

    [EnumMember(Value = "HUF")]
    Forint = 348,

    [EnumMember(Value = "ISK")]
    IcelandKrona = 352,

    [EnumMember(Value = "IDR")]
    Rupiah = 360,

    [EnumMember(Value = "IRR")]
    IranianRial = 364,

    [EnumMember(Value = "IQD")]
    IraqiDinar = 368,

    [EnumMember(Value = "ILS")]
    NewIsraeliSheqel = 376,

    [EnumMember(Value = "JMD")]
    JamaicanDollar = 388,

    [EnumMember(Value = "JPY")]
    Yen = 392,

    [EnumMember(Value = "JOD")]
    JordanianDinar = 400,

    [EnumMember(Value = "KZT")]
    Tenge = 398,

    [EnumMember(Value = "KES")]
    KenyanShilling = 404,

    [EnumMember(Value = "KPW")]
    NorthKoreanWon = 408,

    [EnumMember(Value = "KRW")]
    Won = 410,

    [EnumMember(Value = "KWD")]
    KuwaitiDinar = 414,

    [EnumMember(Value = "KGS")]
    Som = 417,

    [EnumMember(Value = "LAK")]
    LaoKip = 418,

    [EnumMember(Value = "LBP")]
    LebanesePound = 422,

    [EnumMember(Value = "LSL")]
    Loti = 426,

    [EnumMember(Value = "ZAR")]
    Rand = 710,

    [EnumMember(Value = "LRD")]
    LiberianDollar = 430,

    [EnumMember(Value = "LYD")]
    LibyanDinar = 434,

    [EnumMember(Value = "CHF")]
    SwissFranc = 756,

    [EnumMember(Value = "MOP")]
    Pataca = 446,

    [EnumMember(Value = "MKD")]
    Denar = 807,

    [EnumMember(Value = "MGA")]
    MalagasyAriary = 969,

    [EnumMember(Value = "MWK")]
    MalawiKwacha = 454,

    [EnumMember(Value = "MYR")]
    MalaysianRinggit = 458,

    [EnumMember(Value = "MVR")]
    Rufiyaa = 462,

    [EnumMember(Value = "MRU")]
    Ouguiya = 929,

    [EnumMember(Value = "MUR")]
    MauritiusRupee = 480,

    [EnumMember(Value = "XUA")]
    ADBUnitofAccount = 965,

    [EnumMember(Value = "MXN")]
    MexicanPeso = 484,

    [EnumMember(Value = "MDL")]
    MoldovanLeu = 498,

    [EnumMember(Value = "MNT")]
    Tugrik = 496,

    [EnumMember(Value = "MAD")]
    MoroccanDirham = 504,

    [EnumMember(Value = "MZN")]
    MozambiqueMetical = 943,

    [EnumMember(Value = "MMK")]
    Kyat = 104,

    [EnumMember(Value = "NAD")]
    NamibiaDollar = 516,

    [EnumMember(Value = "NPR")]
    NepaleseRupee = 524,

    [EnumMember(Value = "NIO")]
    CordobaOro = 558,

    [EnumMember(Value = "NGN")]
    Naira = 566,

    [EnumMember(Value = "OMR")]
    RialOmani = 512,

    [EnumMember(Value = "PKR")]
    PakistanRupee = 586,

    [EnumMember(Value = "PAB")]
    Balboa = 590,

    [EnumMember(Value = "PGK")]
    Kina = 598,

    [EnumMember(Value = "PYG")]
    Guarani = 600,

    [EnumMember(Value = "PEN")]
    Sol = 604,

    [EnumMember(Value = "PHP")]
    PhilippinePeso = 608,

    [EnumMember(Value = "PLN")]
    Zloty = 985,

    [EnumMember(Value = "QAR")]
    QatariRial = 634,

    [EnumMember(Value = "RON")]
    RomanianLeu = 946,

    [EnumMember(Value = "RUB")]
    RussianRuble = 643,

    [EnumMember(Value = "RWF")]
    RwandaFranc = 646,

    [EnumMember(Value = "SHP")]
    SaintHelenaPound = 654,

    [EnumMember(Value = "WST")]
    Tala = 882,

    [EnumMember(Value = "STN")]
    Dobra = 930,

    [EnumMember(Value = "SAR")]
    SaudiRiyal = 682,

    [EnumMember(Value = "RSD")]
    SerbianDinar = 941,

    [EnumMember(Value = "SCR")]
    SeychellesRupee = 690,

    [EnumMember(Value = "SLL")]
    Leone = 694,

    [EnumMember(Value = "SGD")]
    SingaporeDollar = 702,

    [EnumMember(Value = "XSU")]
    Sucre = 994,

    [EnumMember(Value = "SBD")]
    SolomonIslandsDollar = 090,

    [EnumMember(Value = "SOS")]
    SomaliShilling = 706,

    [EnumMember(Value = "SSP")]
    SouthSudanesePound = 728,

    [EnumMember(Value = "LKR")]
    SriLankaRupee = 144,

    [EnumMember(Value = "SDG")]
    SudanesePound = 938,

    [EnumMember(Value = "SRD")]
    SurinamDollar = 968,

    [EnumMember(Value = "SEK")]
    SwedishKrona = 752,

    [EnumMember(Value = "CHE")]
    WIREuro = 947,

    [EnumMember(Value = "CHW")]
    WIRFranc = 948,

    [EnumMember(Value = "SYP")]
    SyrianPound = 760,

    [EnumMember(Value = "TWD")]
    NewTaiwanDollar = 901,

    [EnumMember(Value = "TJS")]
    Somoni = 972,

    [EnumMember(Value = "TZS")]
    TanzanianShilling = 834,

    [EnumMember(Value = "THB")]
    Baht = 764,

    [EnumMember(Value = "TOP")]
    Paanga = 776,

    [EnumMember(Value = "TTD")]
    TrinidadandTobagoDollar = 780,

    [EnumMember(Value = "TND")]
    TunisianDinar = 788,

    [EnumMember(Value = "TRY")]
    TurkishLira = 949,

    [EnumMember(Value = "TMT")]
    TurkmenistanNewManat = 934,

    [EnumMember(Value = "UGX")]
    UgandaShilling = 800,

    [EnumMember(Value = "UAH")]
    Hryvnia = 980,

    [EnumMember(Value = "AED")]
    UAEDirham = 784,

    [EnumMember(Value = "USN")]
    USDollarNextDay = 997,

    [EnumMember(Value = "UYU")]
    PesoUruguayo = 858,

    [EnumMember(Value = "UYW")]
    UnidadPrevisional = 927,

    [EnumMember(Value = "UZS")]
    UzbekistanSum = 860,

    [EnumMember(Value = "VUV")]
    Vatu = 548,

    [EnumMember(Value = "VES")]
    BolivarSoberano = 928,

    [EnumMember(Value = "VED")]
    BolivarSoberanoDigital = 926,

    [EnumMember(Value = "VND")]
    Dong = 704,

    [EnumMember(Value = "YER")]
    YemeniRial = 886,

    [EnumMember(Value = "ZMW")]
    ZambianKwacha = 967,

    [EnumMember(Value = "ZWL")]
    ZimbabweDollar = 932,
}
