using System.Text.Json.Serialization;

namespace DrawnFromSteel.DTOs.Auth.Session
{
    public record SessionCreateRequest
    {
        [JsonPropertyName("userId")]
        public required int UserId { get; init; }

        [JsonPropertyName("sessionToken")]
        public required string SessionToken { get; init; }

        [JsonPropertyName("expires")]
        //[JsonConverter(typeof(IsoDateTimeConverter))]
        public required DateTime Expires { get; init; }
    }
}
