using System.Runtime.Serialization;

namespace OCPI;

public enum ConnectorFormat : byte
{
    [EnumMember(Value = "SOCKET")]
    Socket = 1,

    [EnumMember(Value = "CABLE")]
    Cable = 2
}
