using System.Text.Json.Serialization;
using System.Text.Json;

namespace OCPI;

internal class OcpiDateTimeConverter : JsonConverter<DateTime>
{
    private const string _format = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffZ";

    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return DateTime.Parse(reader.GetString() ?? string.Empty);
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(_format));
    }
}
