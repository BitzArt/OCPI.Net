using System.Runtime.Serialization;

namespace OCPI;

public enum ImageCategory : byte
{
    /// <summary>
    /// Photo of the physical device that contains one or more EVSEs.
    /// </summary>
    [EnumMember(Value = "CHARGER")]
    Charger = 1,

    /// <summary>
    /// Location entrance photo.
    /// Should show the car entrance to the location from street side.
    /// </summary>
    [EnumMember(Value = "ENTRANCE")]
    Entrance = 2,

    /// <summary>
    /// Location overview photo.
    /// </summary>
    [EnumMember(Value = "LOCATION")]
    Location = 3,

    /// <summary>
    /// Logo of an associated roaming network to be displayed with the EVSE for example in lists,
    /// maps and detailed information views.
    /// </summary>
    [EnumMember(Value = "NETWORK")]
    Network = 4,

    //======================================

    /// <summary>
    /// Logo of the charge point operator, for example a municipality,
    /// to be displayed in the EVSEs detailed information view or in lists and maps,
    ///  if no network logo is present.
    /// </summary>
    [EnumMember(Value = "OPERATOR")]
    Operator = 11,

    /// <summary>
    /// Logo of the charge point owner, for example a local store,
    /// to be displayed in the EVSEs detailed information view.
    /// </summary>
    [EnumMember(Value = "OWNER")]
    Owner = 12,

    //======================================

    /// <summary>
    /// Other
    /// </summary>
    [EnumMember(Value = "OTHER")]
    Other = 255
}
