using System.Text.Json.Serialization;

namespace DrawnFromSteel.DTOs.Auth.Session
{
    public record SessionAndUserGetResponse
    {
        [JsonPropertyName("session")]
        public required SessionGetResponse Session { get; init; }

        [JsonPropertyName("user")]
        public required UserGetResponse User { get; init; }

        public record SessionGetResponse
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

        public record UserGetResponse
        {
            [JsonPropertyName("id")]
            public required int Id { get; init; }

            [JsonPropertyName("name")]
            public required string? Name { get; init; }

            [JsonPropertyName("email")]
            public required string? Email { get; init; }

            [JsonPropertyName("email_verified")]
            public required DateTime? EmailVerified { get; init; }

            [JsonPropertyName("image")]
            public required string? Image { get; init; }

            [JsonPropertyName("created_at")]
            public required DateTime CreatedAt { get; init; }

            [JsonPropertyName("updated_at")]
            public required DateTime UpdatedAt { get; init; }
        }
    }
}
