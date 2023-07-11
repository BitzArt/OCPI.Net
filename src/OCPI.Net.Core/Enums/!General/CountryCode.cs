using System.Runtime.Serialization;

namespace OCPI;

public enum CountryCode : int
{
    [EnumMember(Value = "xx")]
    TestCountry = 1,

    [EnumMember(Value = "af")]
    Afghanistan = 4,

    [EnumMember(Value = "al")]
    Albania = 8,

    [EnumMember(Value = "dz")]
    Algeria = 12,

    [EnumMember(Value = "as")]
    AmericanSamoa = 16,

    [EnumMember(Value = "ad")]
    Andorra = 20,

    [EnumMember(Value = "ao")]
    Angola = 24,

    [EnumMember(Value = "ai")]
    Anguilla = 660,

    [EnumMember(Value = "aq")]
    Antarctica = 10,

    [EnumMember(Value = "ag")]
    AntiguaAndBarbuda = 28,

    [EnumMember(Value = "ar")]
    Argentina = 32,

    [EnumMember(Value = "am")]
    Armenia = 51,

    [EnumMember(Value = "aw")]
    Aruba = 533,

    [EnumMember(Value = "au")]
    Australia = 36,

    [EnumMember(Value = "at")]
    Austria = 40,

    [EnumMember(Value = "az")]
    Azerbaijan = 31,

    [EnumMember(Value = "bs")]
    Bahamas = 44,

    [EnumMember(Value = "bh")]
    Bahrain = 48,

    [EnumMember(Value = "bd")]
    Bangladesh = 50,

    [EnumMember(Value = "bb")]
    Barbados = 52,

    [EnumMember(Value = "by")]
    Belarus = 112,

    [EnumMember(Value = "be")]
    Belgium = 56,

    [EnumMember(Value = "bz")]
    Belize = 84,

    [EnumMember(Value = "bj")]
    Benin = 204,

    [EnumMember(Value = "bm")]
    Bermuda = 60,

    [EnumMember(Value = "bt")]
    Bhutan = 64,

    [EnumMember(Value = "bo")]
    PlurinationalStateOfBolivia = 68,

    [EnumMember(Value = "bq")]
    BonaireSintEustatiusAndSaba = 535,

    [EnumMember(Value = "ba")]
    BosniaAndHerzegovina = 70,

    [EnumMember(Value = "bw")]
    Botswana = 72,

    [EnumMember(Value = "bv")]
    BouvetIsland = 74,

    [EnumMember(Value = "br")]
    Brazil = 76,

    [EnumMember(Value = "io")]
    TheBritishIndianOceanTerritory = 86,

    [EnumMember(Value = "bn")]
    BruneiDarussalam = 96,

    [EnumMember(Value = "bg")]
    Bulgaria = 100,

    [EnumMember(Value = "bf")]
    BurkinaFaso = 854,

    [EnumMember(Value = "bi")]
    Burundi = 108,

    [EnumMember(Value = "cv")]
    CaboVerde = 132,

    [EnumMember(Value = "kh")]
    Cambodia = 116,

    [EnumMember(Value = "cm")]
    Cameroon = 120,

    [EnumMember(Value = "ca")]
    Canada = 124,

    [EnumMember(Value = "ky")]
    TheCaymanIslands = 136,

    [EnumMember(Value = "cf")]
    TheCentralAfricanRepublic = 140,

    [EnumMember(Value = "td")]
    Chad = 148,

    [EnumMember(Value = "cl")]
    Chile = 152,

    [EnumMember(Value = "cn")]
    China = 156,

    [EnumMember(Value = "cx")]
    ChristmasIsland = 162,

    [EnumMember(Value = "cc")]
    TheCocosIslands = 166,

    [EnumMember(Value = "co")]
    Colombia = 170,

    [EnumMember(Value = "km")]
    Comoros = 174,

    [EnumMember(Value = "cd")]
    DemocraticRepublicOfTheCongo = 180,

    [EnumMember(Value = "cg")]
    Congo = 178,

    [EnumMember(Value = "ck")]
    CookIslands = 184,

    [EnumMember(Value = "cr")]
    CostaRica = 188,

    [EnumMember(Value = "hr")]
    Croatia = 191,

    [EnumMember(Value = "cu")]
    Cuba = 192,

    [EnumMember(Value = "cw")]
    Curaçao = 531,

    [EnumMember(Value = "cy")]
    Cyprus = 196,

    [EnumMember(Value = "cz")]
    CzechRepublic = 203,

    [EnumMember(Value = "ci")]
    CoteDIvoire = 384,

    [EnumMember(Value = "dk")]
    Denmark = 208,

    [EnumMember(Value = "dj")]
    Djibouti = 262,

    [EnumMember(Value = "dm")]
    Dominica = 212,

    [EnumMember(Value = "do")]
    TheDominicanRepublic = 214,

    [EnumMember(Value = "ec")]
    Ecuador = 218,

    [EnumMember(Value = "eg")]
    Egypt = 818,

    [EnumMember(Value = "sv")]
    ElSalvador = 222,

    [EnumMember(Value = "gq")]
    EquatorialGuinea = 226,

    [EnumMember(Value = "er")]
    Eritrea = 232,

    [EnumMember(Value = "ee")]
    Estonia = 233,

    [EnumMember(Value = "sz")]
    Eswatini = 748,

    [EnumMember(Value = "et")]
    Ethiopia = 231,

    [EnumMember(Value = "fk")]
    Malvinas = 238,

    [EnumMember(Value = "fo")]
    TheFaroeIslands = 234,

    [EnumMember(Value = "fj")]
    Fiji = 242,

    [EnumMember(Value = "fi")]
    Finland = 246,

    [EnumMember(Value = "fr")]
    France = 250,

    [EnumMember(Value = "gf")]
    FrenchGuiana = 254,

    [EnumMember(Value = "pf")]
    FrenchPolynesia = 258,

    [EnumMember(Value = "tf")]
    TheFrenchSouthernTerritories = 260,

    [EnumMember(Value = "ga")]
    Gabon = 266,

    [EnumMember(Value = "gm")]
    TheGambia = 270,

    [EnumMember(Value = "ge")]
    Georgia = 268,

    [EnumMember(Value = "de")]
    Germany = 276,

    [EnumMember(Value = "gh")]
    Ghana = 288,

    [EnumMember(Value = "gi")]
    Gibraltar = 292,

    [EnumMember(Value = "gr")]
    Greece = 300,

    [EnumMember(Value = "gl")]
    Greenland = 304,

    [EnumMember(Value = "gd")]
    Grenada = 308,

    [EnumMember(Value = "gp")]
    Guadeloupe = 312,

    [EnumMember(Value = "gu")]
    Guam = 316,

    [EnumMember(Value = "gt")]
    Guatemala = 320,

    [EnumMember(Value = "gg")]
    Guernsey = 831,

    [EnumMember(Value = "gn")]
    Guinea = 324,

    [EnumMember(Value = "gw")]
    GuineaBissau = 624,

    [EnumMember(Value = "gy")]
    Guyana = 328,

    [EnumMember(Value = "ht")]
    Haiti = 332,

    [EnumMember(Value = "hm")]
    HeardIslandandMcDonaldIslands = 334,

    [EnumMember(Value = "va")]
    TheHolySee = 336,

    [EnumMember(Value = "hn")]
    Honduras = 340,

    [EnumMember(Value = "hk")]
    HongKong = 344,

    [EnumMember(Value = "hu")]
    Hungary = 348,

    [EnumMember(Value = "is")]
    Iceland = 352,

    [EnumMember(Value = "in")]
    India = 356,

    [EnumMember(Value = "id")]
    Indonesia = 360,

    [EnumMember(Value = "ir")]
    Iran = 364,

    [EnumMember(Value = "iq")]
    Iraq = 368,

    [EnumMember(Value = "ie")]
    Ireland = 372,

    [EnumMember(Value = "im")]
    IsleOfMan = 833,

    [EnumMember(Value = "il")]
    Israel = 376,

    [EnumMember(Value = "it")]
    Italy = 380,

    [EnumMember(Value = "jm")]
    Jamaica = 388,

    [EnumMember(Value = "jp")]
    Japan = 392,

    [EnumMember(Value = "je")]
    Jersey = 832,

    [EnumMember(Value = "jo")]
    Jordan = 400,

    [EnumMember(Value = "kz")]
    Kazakhstan = 398,

    [EnumMember(Value = "ke")]
    Kenya = 404,

    [EnumMember(Value = "ki")]
    Kiribati = 296,

    [EnumMember(Value = "kp")]
    NorthKorea = 408,

    [EnumMember(Value = "kr")]
    SouthKorea = 410,

    [EnumMember(Value = "kw")]
    Kuwait = 414,

    [EnumMember(Value = "kg")]
    Kyrgyzstan = 417,

    [EnumMember(Value = "la")]
    Laos = 418,

    [EnumMember(Value = "lv")]
    Latvia = 428,

    [EnumMember(Value = "lb")]
    Lebanon = 422,

    [EnumMember(Value = "ls")]
    Lesotho = 426,

    [EnumMember(Value = "lr")]
    Liberia = 430,

    [EnumMember(Value = "ly")]
    Libya = 434,

    [EnumMember(Value = "li")]
    Liechtenstein = 438,

    [EnumMember(Value = "lt")]
    Lithuania = 440,

    [EnumMember(Value = "lu")]
    Luxembourg = 442,

    [EnumMember(Value = "mo")]
    Macao = 446,

    [EnumMember(Value = "mg")]
    Madagascar = 450,

    [EnumMember(Value = "mw")]
    Malawi = 454,

    [EnumMember(Value = "my")]
    Malaysia = 458,

    [EnumMember(Value = "mv")]
    Maldives = 462,

    [EnumMember(Value = "ml")]
    Mali = 466,

    [EnumMember(Value = "mt")]
    Malta = 470,

    [EnumMember(Value = "mh")]
    TheMarshallIslands = 584,

    [EnumMember(Value = "mq")]
    Martinique = 474,

    [EnumMember(Value = "mr")]
    Mauritania = 478,

    [EnumMember(Value = "mu")]
    Mauritius = 480,

    [EnumMember(Value = "yt")]
    Mayotte = 175,

    [EnumMember(Value = "mx")]
    Mexico = 484,

    [EnumMember(Value = "fm")]
    Micronesia = 583,

    [EnumMember(Value = "md")]
    Moldova = 498,

    [EnumMember(Value = "mc")]
    Monaco = 492,

    [EnumMember(Value = "mn")]
    Mongolia = 496,

    [EnumMember(Value = "me")]
    Montenegro = 499,

    [EnumMember(Value = "ms")]
    Montserrat = 500,

    [EnumMember(Value = "ma")]
    Morocco = 504,

    [EnumMember(Value = "mz")]
    Mozambique = 508,

    [EnumMember(Value = "mm")]
    Myanmar = 104,

    [EnumMember(Value = "na")]
    Namibia = 516,

    [EnumMember(Value = "nr")]
    Nauru = 520,

    [EnumMember(Value = "np")]
    Nepal = 524,

    [EnumMember(Value = "nl")]
    TheNetherlands = 528,

    [EnumMember(Value = "nc")]
    NewCaledonia = 540,

    [EnumMember(Value = "nz")]
    NewZealand = 554,

    [EnumMember(Value = "ni")]
    Nicaragua = 558,

    [EnumMember(Value = "ne")]
    TheNiger = 562,

    [EnumMember(Value = "ng")]
    Nigeria = 566,

    [EnumMember(Value = "nu")]
    Niue = 570,

    [EnumMember(Value = "nf")]
    NorfolkIsland = 574,

    [EnumMember(Value = "mp")]
    TheNorthernMarianaIslands = 580,

    [EnumMember(Value = "no")]
    Norway = 578,

    [EnumMember(Value = "om")]
    Oman = 512,

    [EnumMember(Value = "pk")]
    Pakistan = 586,

    [EnumMember(Value = "pw")]
    Palau = 585,

    [EnumMember(Value = "ps")]
    StateOfPalestine = 275,

    [EnumMember(Value = "pa")]
    Panama = 591,

    [EnumMember(Value = "pg")]
    PapuaNewGuinea = 598,

    [EnumMember(Value = "py")]
    Paraguay = 600,

    [EnumMember(Value = "pe")]
    Peru = 604,

    [EnumMember(Value = "ph")]
    ThePhilippines = 608,

    [EnumMember(Value = "pn")]
    Pitcairn = 612,

    [EnumMember(Value = "pl")]
    Poland = 616,

    [EnumMember(Value = "pt")]
    Portugal = 620,

    [EnumMember(Value = "pr")]
    PuertoRico = 630,

    [EnumMember(Value = "qa")]
    Qatar = 634,

    [EnumMember(Value = "mk")]
    RepublicOfNorthMacedonia = 807,

    [EnumMember(Value = "ro")]
    Romania = 642,

    [EnumMember(Value = "ru")]
    TheRussianFederation = 643,

    [EnumMember(Value = "rw")]
    Rwanda = 646,

    [EnumMember(Value = "re")]
    Réunion = 638,

    [EnumMember(Value = "bl")]
    SaintBarthélemy = 652,

    [EnumMember(Value = "sh")]
    AscensionAndTristanDaCunhaSaintHelena = 654,

    [EnumMember(Value = "kn")]
    SaintKittsAndNevis = 659,

    [EnumMember(Value = "lc")]
    SaintLucia = 662,

    [EnumMember(Value = "mf")]
    SaintMartinFrenchPart = 663,

    [EnumMember(Value = "pm")]
    SaintPierreAndMiquelon = 666,

    [EnumMember(Value = "vc")]
    SaintVincentAndTheGrenadines = 670,

    [EnumMember(Value = "ws")]
    Samoa = 882,

    [EnumMember(Value = "sm")]
    SanMarino = 674,

    [EnumMember(Value = "st")]
    SaoTomeAndPrincipe = 678,

    [EnumMember(Value = "sa")]
    SaudiArabia = 682,

    [EnumMember(Value = "sn")]
    Senegal = 686,

    [EnumMember(Value = "rs")]
    Serbia = 688,

    [EnumMember(Value = "sc")]
    Seychelles = 690,

    [EnumMember(Value = "sl")]
    SierraLeone = 694,

    [EnumMember(Value = "sg")]
    Singapore = 702,

    [EnumMember(Value = "sx")]
    SintMaartenDutchPart = 534,

    [EnumMember(Value = "sk")]
    Slovakia = 703,

    [EnumMember(Value = "si")]
    Slovenia = 705,

    [EnumMember(Value = "sb")]
    SolomonIslands = 90,

    [EnumMember(Value = "so")]
    Somalia = 706,

    [EnumMember(Value = "za")]
    SouthAfrica = 710,

    [EnumMember(Value = "gs")]
    SouthGeorgiaAndTheSouthSandwichIslands = 239,

    [EnumMember(Value = "ss")]
    SouthSudan = 728,

    [EnumMember(Value = "es")]
    Spain = 724,

    [EnumMember(Value = "lk")]
    SriLanka = 144,

    [EnumMember(Value = "sd")]
    TheSudan = 729,

    [EnumMember(Value = "sr")]
    Suriname = 740,

    [EnumMember(Value = "sj")]
    SvalbardAndJanMayen = 744,

    [EnumMember(Value = "se")]
    Sweden = 752,

    [EnumMember(Value = "ch")]
    Switzerland = 756,

    [EnumMember(Value = "sy")]
    SyrianArabRepublic = 760,

    [EnumMember(Value = "tw")]
    Taiwan = 158,

    [EnumMember(Value = "tj")]
    Tajikistan = 762,

    [EnumMember(Value = "tz")]
    UnitedRepublicOfTanzania = 834,

    [EnumMember(Value = "th")]
    Thailand = 764,

    [EnumMember(Value = "tl")]
    TimorLeste = 626,

    [EnumMember(Value = "tg")]
    Togo = 768,

    [EnumMember(Value = "tk")]
    Tokelau = 772,

    [EnumMember(Value = "to")]
    Tonga = 776,

    [EnumMember(Value = "tt")]
    TrinidadAndTobago = 780,

    [EnumMember(Value = "tn")]
    Tunisia = 788,

    [EnumMember(Value = "tr")]
    Turkey = 792,

    [EnumMember(Value = "tm")]
    Turkmenistan = 795,

    [EnumMember(Value = "tc")]
    TheTurksAndCaicosIslands = 796,

    [EnumMember(Value = "tv")]
    Tuvalu = 798,

    [EnumMember(Value = "ug")]
    Uganda = 800,

    [EnumMember(Value = "ua")]
    Ukraine = 804,

    [EnumMember(Value = "ae")]
    TheUnitedArabEmirates = 784,

    [EnumMember(Value = "gb")]
    TheUnitedKingdomOfGreatBritainAndNorthernIreland = 826,

    [EnumMember(Value = "um")]
    TheUnitedStatesMinorOutlyingIslands = 581,

    [EnumMember(Value = "us")]
    TheUnitedStatesOfAmerica = 840,

    [EnumMember(Value = "uy")]
    Uruguay = 858,

    [EnumMember(Value = "uz")]
    Uzbekistan = 860,

    [EnumMember(Value = "vu")]
    Vanuatu = 548,

    [EnumMember(Value = "ve")]
    Venezuela = 862,

    [EnumMember(Value = "vn")]
    VietNam = 704,

    [EnumMember(Value = "vg")]
    VirginIslandsBritish = 92,

    [EnumMember(Value = "vi")]
    VirginIslandsUS = 850,

    [EnumMember(Value = "wf")]
    WallisAndFutuna = 876,

    [EnumMember(Value = "eh")]
    WesternSahara = 732,

    [EnumMember(Value = "ye")]
    Yemen = 887,

    [EnumMember(Value = "zm")]
    Zambia = 894,

    [EnumMember(Value = "zw")]
    Zimbabwe = 716,

    [EnumMember(Value = "ax")]
    ÅlandIslands = 248,
}
