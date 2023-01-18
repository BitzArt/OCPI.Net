using System.Runtime.Serialization;

namespace OCPI;

public enum CountryCode : int
{
    [EnumMember(Value = "XX")]
    TestCountry = 1,

    [EnumMember(Value = "AF")]
    Afghanistan = 4,

    [EnumMember(Value = "AL")]
    Albania = 8,

    [EnumMember(Value = "DZ")]
    Algeria = 12,

    [EnumMember(Value = "AS")]
    AmericanSamoa = 16,

    [EnumMember(Value = "AD")]
    Andorra = 20,

    [EnumMember(Value = "AO")]
    Angola = 24,

    [EnumMember(Value = "AI")]
    Anguilla = 660,

    [EnumMember(Value = "AQ")]
    Antarctica = 10,

    [EnumMember(Value = "AG")]
    AntiguaAndBarbuda = 28,

    [EnumMember(Value = "AR")]
    Argentina = 32,

    [EnumMember(Value = "AM")]
    Armenia = 51,

    [EnumMember(Value = "AW")]
    Aruba = 533,

    [EnumMember(Value = "AU")]
    Australia = 36,

    [EnumMember(Value = "AT")]
    Austria = 40,

    [EnumMember(Value = "AZ")]
    Azerbaijan = 31,

    [EnumMember(Value = "BS")]
    Bahamas = 44,

    [EnumMember(Value = "BH")]
    Bahrain = 48,

    [EnumMember(Value = "BD")]
    Bangladesh = 50,

    [EnumMember(Value = "BB")]
    Barbados = 52,

    [EnumMember(Value = "BY")]
    Belarus = 112,

    [EnumMember(Value = "BE")]
    Belgium = 56,

    [EnumMember(Value = "BZ")]
    Belize = 84,

    [EnumMember(Value = "BJ")]
    Benin = 204,

    [EnumMember(Value = "BM")]
    Bermuda = 60,

    [EnumMember(Value = "BT")]
    Bhutan = 64,

    [EnumMember(Value = "BO")]
    PlurinationalStateOfBolivia = 68,

    [EnumMember(Value = "BQ")]
    BonaireSintEustatiusAndSaba = 535,

    [EnumMember(Value = "BA")]
    BosniaAndHerzegovina = 70,

    [EnumMember(Value = "BW")]
    Botswana = 72,

    [EnumMember(Value = "BV")]
    BouvetIsland = 74,

    [EnumMember(Value = "BR")]
    Brazil = 76,

    [EnumMember(Value = "IO")]
    TheBritishIndianOceanTerritory = 86,

    [EnumMember(Value = "BN")]
    BruneiDarussalam = 96,

    [EnumMember(Value = "BG")]
    Bulgaria = 100,

    [EnumMember(Value = "BF")]
    BurkinaFaso = 854,

    [EnumMember(Value = "BI")]
    Burundi = 108,

    [EnumMember(Value = "CV")]
    CaboVerde = 132,

    [EnumMember(Value = "KH")]
    Cambodia = 116,

    [EnumMember(Value = "CM")]
    Cameroon = 120,

    [EnumMember(Value = "CA")]
    Canada = 124,

    [EnumMember(Value = "KY")]
    TheCaymanIslands = 136,

    [EnumMember(Value = "CF")]
    TheCentralAfricanRepublic = 140,

    [EnumMember(Value = "TD")]
    Chad = 148,

    [EnumMember(Value = "CL")]
    Chile = 152,

    [EnumMember(Value = "CN")]
    China = 156,

    [EnumMember(Value = "CX")]
    ChristmasIsland = 162,

    [EnumMember(Value = "CC")]
    TheCocosIslands = 166,

    [EnumMember(Value = "CO")]
    Colombia = 170,

    [EnumMember(Value = "KM")]
    Comoros = 174,

    [EnumMember(Value = "CD")]
    DemocraticRepublicOfTheCongo = 180,

    [EnumMember(Value = "CG")]
    Congo = 178,

    [EnumMember(Value = "CK")]
    CookIslands = 184,

    [EnumMember(Value = "CR")]
    CostaRica = 188,

    [EnumMember(Value = "HR")]
    Croatia = 191,

    [EnumMember(Value = "CU")]
    Cuba = 192,

    [EnumMember(Value = "CW")]
    Curaçao = 531,

    [EnumMember(Value = "CY")]
    Cyprus = 196,

    [EnumMember(Value = "CZ")]
    CzechRepublic = 203,

    [EnumMember(Value = "CI")]
    CoteDIvoire = 384,

    [EnumMember(Value = "DK")]
    Denmark = 208,

    [EnumMember(Value = "DJ")]
    Djibouti = 262,

    [EnumMember(Value = "DM")]
    Dominica = 212,

    [EnumMember(Value = "DO")]
    TheDominicanRepublic = 214,

    [EnumMember(Value = "EC")]
    Ecuador = 218,

    [EnumMember(Value = "EG")]
    Egypt = 818,

    [EnumMember(Value = "SV")]
    ElSalvador = 222,

    [EnumMember(Value = "GQ")]
    EquatorialGuinea = 226,

    [EnumMember(Value = "ER")]
    Eritrea = 232,

    [EnumMember(Value = "EE")]
    Estonia = 233,

    [EnumMember(Value = "SZ")]
    Eswatini = 748,

    [EnumMember(Value = "ET")]
    Ethiopia = 231,

    [EnumMember(Value = "FK")]
    Malvinas = 238,

    [EnumMember(Value = "FO")]
    TheFaroeIslands = 234,

    [EnumMember(Value = "FJ")]
    Fiji = 242,

    [EnumMember(Value = "FI")]
    Finland = 246,

    [EnumMember(Value = "FR")]
    France = 250,

    [EnumMember(Value = "GF")]
    FrenchGuiana = 254,

    [EnumMember(Value = "PF")]
    FrenchPolynesia = 258,

    [EnumMember(Value = "TF")]
    TheFrenchSouthernTerritories = 260,

    [EnumMember(Value = "GA")]
    Gabon = 266,

    [EnumMember(Value = "GM")]
    TheGambia = 270,

    [EnumMember(Value = "GE")]
    Georgia = 268,

    [EnumMember(Value = "DE")]
    Germany = 276,

    [EnumMember(Value = "GH")]
    Ghana = 288,

    [EnumMember(Value = "GI")]
    Gibraltar = 292,

    [EnumMember(Value = "GR")]
    Greece = 300,

    [EnumMember(Value = "GL")]
    Greenland = 304,

    [EnumMember(Value = "GD")]
    Grenada = 308,

    [EnumMember(Value = "GP")]
    Guadeloupe = 312,

    [EnumMember(Value = "GU")]
    Guam = 316,

    [EnumMember(Value = "GT")]
    Guatemala = 320,

    [EnumMember(Value = "GG")]
    Guernsey = 831,

    [EnumMember(Value = "GN")]
    Guinea = 324,

    [EnumMember(Value = "GW")]
    GuineaBissau = 624,

    [EnumMember(Value = "GY")]
    Guyana = 328,

    [EnumMember(Value = "HT")]
    Haiti = 332,

    [EnumMember(Value = "HM")]
    HeardIslandandMcDonaldIslands = 334,

    [EnumMember(Value = "VA")]
    TheHolySee = 336,

    [EnumMember(Value = "HN")]
    Honduras = 340,

    [EnumMember(Value = "HK")]
    HongKong = 344,

    [EnumMember(Value = "HU")]
    Hungary = 348,

    [EnumMember(Value = "IS")]
    Iceland = 352,

    [EnumMember(Value = "IN")]
    India = 356,

    [EnumMember(Value = "ID")]
    Indonesia = 360,

    [EnumMember(Value = "IR")]
    Iran = 364,

    [EnumMember(Value = "IQ")]
    Iraq = 368,

    [EnumMember(Value = "IE")]
    Ireland = 372,

    [EnumMember(Value = "IM")]
    IsleOfMan = 833,

    [EnumMember(Value = "IL")]
    Israel = 376,

    [EnumMember(Value = "IT")]
    Italy = 380,

    [EnumMember(Value = "JM")]
    Jamaica = 388,

    [EnumMember(Value = "JP")]
    Japan = 392,

    [EnumMember(Value = "JE")]
    Jersey = 832,

    [EnumMember(Value = "JO")]
    Jordan = 400,

    [EnumMember(Value = "KZ")]
    Kazakhstan = 398,

    [EnumMember(Value = "KE")]
    Kenya = 404,

    [EnumMember(Value = "KI")]
    Kiribati = 296,

    [EnumMember(Value = "KP")]
    NorthKorea = 408,

    [EnumMember(Value = "KR")]
    SouthKorea = 410,

    [EnumMember(Value = "KW")]
    Kuwait = 414,

    [EnumMember(Value = "KG")]
    Kyrgyzstan = 417,

    [EnumMember(Value = "LA")]
    Laos = 418,

    [EnumMember(Value = "LV")]
    Latvia = 428,

    [EnumMember(Value = "LB")]
    Lebanon = 422,

    [EnumMember(Value = "LS")]
    Lesotho = 426,

    [EnumMember(Value = "LR")]
    Liberia = 430,

    [EnumMember(Value = "LY")]
    Libya = 434,

    [EnumMember(Value = "LI")]
    Liechtenstein = 438,

    [EnumMember(Value = "LT")]
    Lithuania = 440,

    [EnumMember(Value = "LU")]
    Luxembourg = 442,

    [EnumMember(Value = "MO")]
    Macao = 446,

    [EnumMember(Value = "MG")]
    Madagascar = 450,

    [EnumMember(Value = "MW")]
    Malawi = 454,

    [EnumMember(Value = "MY")]
    Malaysia = 458,

    [EnumMember(Value = "MV")]
    Maldives = 462,

    [EnumMember(Value = "ML")]
    Mali = 466,

    [EnumMember(Value = "MT")]
    Malta = 470,

    [EnumMember(Value = "MH")]
    TheMarshallIslands = 584,

    [EnumMember(Value = "MQ")]
    Martinique = 474,

    [EnumMember(Value = "MR")]
    Mauritania = 478,

    [EnumMember(Value = "MU")]
    Mauritius = 480,

    [EnumMember(Value = "YT")]
    Mayotte = 175,

    [EnumMember(Value = "MX")]
    Mexico = 484,

    [EnumMember(Value = "FM")]
    Micronesia = 583,

    [EnumMember(Value = "MD")]
    Moldova = 498,

    [EnumMember(Value = "MC")]
    Monaco = 492,

    [EnumMember(Value = "MN")]
    Mongolia = 496,

    [EnumMember(Value = "ME")]
    Montenegro = 499,

    [EnumMember(Value = "MS")]
    Montserrat = 500,

    [EnumMember(Value = "MA")]
    Morocco = 504,

    [EnumMember(Value = "MZ")]
    Mozambique = 508,

    [EnumMember(Value = "MM")]
    Myanmar = 104,

    [EnumMember(Value = "NA")]
    Namibia = 516,

    [EnumMember(Value = "NR")]
    Nauru = 520,

    [EnumMember(Value = "NP")]
    Nepal = 524,

    [EnumMember(Value = "NL")]
    TheNetherlands = 528,

    [EnumMember(Value = "NC")]
    NewCaledonia = 540,

    [EnumMember(Value = "NZ")]
    NewZealand = 554,

    [EnumMember(Value = "NI")]
    Nicaragua = 558,

    [EnumMember(Value = "NE")]
    TheNiger = 562,

    [EnumMember(Value = "NG")]
    Nigeria = 566,

    [EnumMember(Value = "NU")]
    Niue = 570,

    [EnumMember(Value = "NF")]
    NorfolkIsland = 574,

    [EnumMember(Value = "MP")]
    TheNorthernMarianaIslands = 580,

    [EnumMember(Value = "NO")]
    Norway = 578,

    [EnumMember(Value = "OM")]
    Oman = 512,

    [EnumMember(Value = "PK")]
    Pakistan = 586,

    [EnumMember(Value = "PW")]
    Palau = 585,

    [EnumMember(Value = "PS")]
    StateOfPalestine = 275,

    [EnumMember(Value = "PA")]
    Panama = 591,

    [EnumMember(Value = "PG")]
    PapuaNewGuinea = 598,

    [EnumMember(Value = "PY")]
    Paraguay = 600,

    [EnumMember(Value = "PE")]
    Peru = 604,

    [EnumMember(Value = "PH")]
    ThePhilippines = 608,

    [EnumMember(Value = "PN")]
    Pitcairn = 612,

    [EnumMember(Value = "PL")]
    Poland = 616,

    [EnumMember(Value = "PT")]
    Portugal = 620,

    [EnumMember(Value = "PR")]
    PuertoRico = 630,

    [EnumMember(Value = "QA")]
    Qatar = 634,

    [EnumMember(Value = "MK")]
    RepublicOfNorthMacedonia = 807,

    [EnumMember(Value = "RO")]
    Romania = 642,

    [EnumMember(Value = "RU")]
    TheRussianFederation = 643,

    [EnumMember(Value = "RW")]
    Rwanda = 646,

    [EnumMember(Value = "RE")]
    Réunion = 638,

    [EnumMember(Value = "BL")]
    SaintBarthélemy = 652,

    [EnumMember(Value = "SH")]
    AscensionAndTristanDaCunhaSaintHelena = 654,

    [EnumMember(Value = "KN")]
    SaintKittsAndNevis = 659,

    [EnumMember(Value = "LC")]
    SaintLucia = 662,

    [EnumMember(Value = "MF")]
    SaintMartinFrenchPart = 663,

    [EnumMember(Value = "PM")]
    SaintPierreAndMiquelon = 666,

    [EnumMember(Value = "VC")]
    SaintVincentAndTheGrenadines = 670,

    [EnumMember(Value = "WS")]
    Samoa = 882,

    [EnumMember(Value = "SM")]
    SanMarino = 674,

    [EnumMember(Value = "ST")]
    SaoTomeAndPrincipe = 678,

    [EnumMember(Value = "SA")]
    SaudiArabia = 682,

    [EnumMember(Value = "SN")]
    Senegal = 686,

    [EnumMember(Value = "RS")]
    Serbia = 688,

    [EnumMember(Value = "SC")]
    Seychelles = 690,

    [EnumMember(Value = "SL")]
    SierraLeone = 694,

    [EnumMember(Value = "SG")]
    Singapore = 702,

    [EnumMember(Value = "SX")]
    SintMaartenDutchPart = 534,

    [EnumMember(Value = "SK")]
    Slovakia = 703,

    [EnumMember(Value = "SI")]
    Slovenia = 705,

    [EnumMember(Value = "SB")]
    SolomonIslands = 90,

    [EnumMember(Value = "SO")]
    Somalia = 706,

    [EnumMember(Value = "ZA")]
    SouthAfrica = 710,

    [EnumMember(Value = "GS")]
    SouthGeorgiaAndTheSouthSandwichIslands = 239,

    [EnumMember(Value = "SS")]
    SouthSudan = 728,

    [EnumMember(Value = "ES")]
    Spain = 724,

    [EnumMember(Value = "LK")]
    SriLanka = 144,

    [EnumMember(Value = "SD")]
    TheSudan = 729,

    [EnumMember(Value = "SR")]
    Suriname = 740,

    [EnumMember(Value = "SJ")]
    SvalbardAndJanMayen = 744,

    [EnumMember(Value = "SE")]
    Sweden = 752,

    [EnumMember(Value = "CH")]
    Switzerland = 756,

    [EnumMember(Value = "SY")]
    SyrianArabRepublic = 760,

    [EnumMember(Value = "TW")]
    Taiwan = 158,

    [EnumMember(Value = "TJ")]
    Tajikistan = 762,

    [EnumMember(Value = "TZ")]
    UnitedRepublicOfTanzania = 834,

    [EnumMember(Value = "TH")]
    Thailand = 764,

    [EnumMember(Value = "TL")]
    TimorLeste = 626,

    [EnumMember(Value = "TG")]
    Togo = 768,

    [EnumMember(Value = "TK")]
    Tokelau = 772,

    [EnumMember(Value = "TO")]
    Tonga = 776,

    [EnumMember(Value = "TT")]
    TrinidadAndTobago = 780,

    [EnumMember(Value = "TN")]
    Tunisia = 788,

    [EnumMember(Value = "TR")]
    Turkey = 792,

    [EnumMember(Value = "TM")]
    Turkmenistan = 795,

    [EnumMember(Value = "TC")]
    TheTurksAndCaicosIslands = 796,

    [EnumMember(Value = "TV")]
    Tuvalu = 798,

    [EnumMember(Value = "UG")]
    Uganda = 800,

    [EnumMember(Value = "UA")]
    Ukraine = 804,

    [EnumMember(Value = "AE")]
    TheUnitedArabEmirates = 784,

    [EnumMember(Value = "GB")]
    TheUnitedKingdomOfGreatBritainAndNorthernIreland = 826,

    [EnumMember(Value = "UM")]
    TheUnitedStatesMinorOutlyingIslands = 581,

    [EnumMember(Value = "US")]
    TheUnitedStatesOfAmerica = 840,

    [EnumMember(Value = "UY")]
    Uruguay = 858,

    [EnumMember(Value = "UZ")]
    Uzbekistan = 860,

    [EnumMember(Value = "VU")]
    Vanuatu = 548,

    [EnumMember(Value = "VE")]
    Venezuela = 862,

    [EnumMember(Value = "VN")]
    VietNam = 704,

    [EnumMember(Value = "VG")]
    VirginIslandsBritish = 92,

    [EnumMember(Value = "VI")]
    VirginIslandsUS = 850,

    [EnumMember(Value = "WF")]
    WallisAndFutuna = 876,

    [EnumMember(Value = "EH")]
    WesternSahara = 732,

    [EnumMember(Value = "YE")]
    Yemen = 887,

    [EnumMember(Value = "ZM")]
    Zambia = 894,

    [EnumMember(Value = "ZW")]
    Zimbabwe = 716,

    [EnumMember(Value = "AX")]
    ÅlandIslands = 248,
}
