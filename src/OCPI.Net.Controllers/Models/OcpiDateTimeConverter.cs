using System.Text.Json;
using System.Text.Json.Serialization;

namespace OCPI;

internal class OcpiDateTimeConverter : JsonConverter<DateTime>
{
    private const string _format = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffZ";

    private static readonly DateTime _start = new(2010, 1, 1);
    private static readonly DateTime _end = new(2100, 1, 1);

    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString();

        if (str is null) return DateTime.MinValue;

        var result = DateTime.Parse(str);
        if (result < _start || result > _end) throw OcpiException.ClientError($"Invalid DateTime value '{str}'.");
        return result;
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(_format));
    }
}
