using System.Text.Json.Serialization;

namespace DrawnFromSteel.DTOs.Auth.Session
{
    public record SessionUpdateRequest
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("userId")]
        public required int UserId { get; init; }

        [JsonPropertyName("sessionToken")]
        public required string SessionToken { get; init; }

        [JsonPropertyName("expires")]
        //[JsonConverter(typeof(IsoDateTimeConverter))]
        public required DateTime Expires { get; init; }
    }
}
