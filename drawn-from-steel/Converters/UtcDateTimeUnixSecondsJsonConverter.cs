using System.Text.Json;
using System.Text.Json.Serialization;

namespace DrawnFromSteel.Converters
{
    public class UtcDateTimeUnixSecondsJsonConverter : JsonConverter<DateTime?>
    {
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int? seconds = reader.TokenType == JsonTokenType.Null ? null : reader.GetInt32();
            if (seconds == null)
            {
                return null;
            }
            else
            {
                return DateTimeOffset.FromUnixTimeSeconds(seconds.Value).UtcDateTime;
            }
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteNumberValue((int)value.Value.Subtract(DateTime.UnixEpoch).TotalSeconds);
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }
}
