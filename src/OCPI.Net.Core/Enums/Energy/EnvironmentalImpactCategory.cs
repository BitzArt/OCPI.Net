using System.Runtime.Serialization;

namespace OCPI;

public enum EnvironmentalImpactCategory : byte
{
    [EnumMember(Value = "CARBON_DIOXIDE")]
    CarbonDioxide = 11,

    //======================================

    [EnumMember(Value = "NUCLEAR_WASTE")]
    NuclearWaste = 21
}
