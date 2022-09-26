using System.Runtime.Serialization;

namespace OCPI.Contracts
{
    public enum ConnectorFormat : byte
    {
        [EnumMember(Value = "SOCKET")]
        Socket = 1,

        [EnumMember(Value = "CABLE")]
        Cable = 2
    }
}
