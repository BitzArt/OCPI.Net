using System.Runtime.Serialization;

namespace OCPI.Versioning
{
    public enum InterfaceRole
    {
        [EnumMember(Value = "SENDER")]
        Sender,

        [EnumMember(Value = "RECEIVER")]
        Receiver,
    }
}
