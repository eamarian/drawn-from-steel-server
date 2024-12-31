using System.Text.Json.Serialization;

namespace DrawnFromSteel.DTOs.Auth.Session
{
    public record SessionUpdateResponse
    {
        [JsonPropertyName("id")]
        public required int Id { get; init; }

        [JsonPropertyName("userId")]
        public required int UserId { get; init; }

        [JsonPropertyName("sessionToken")]
        public required string SessionToken { get; init; }

        [JsonPropertyName("expires")]
        //[JsonConverter(typeof(IsoDateTimeConverter))]
        public required DateTime Expires { get; init; }

        [JsonPropertyName("created_at")]
        public required DateTime CreatedAt { get; init; }

        [JsonPropertyName("updated_at")]
        public required DateTime UpdatedAt { get; init; }
    }
}
