using DrawnFromSteel.Converters;
using System.Text.Json.Serialization;

namespace DrawnFromSteel.DTOs.Auth.Account
{
    public record AccountCreateResponse
    {
        [JsonPropertyName("id")]
        public required int Id { get; init; }

        [JsonPropertyName("userId")]
        public required int UserId { get; init; }

        [JsonPropertyName("type")]
        public required string ProviderType { get; init; }

        [JsonPropertyName("provider")]
        public required string ProviderId { get; init; }

        [JsonPropertyName("providerAccountId")]
        public required string ProviderAccountId { get; init; }

        [JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; init; }

        [JsonPropertyName("access_token")]
        public string? AccessToken { get; init; }

        [JsonPropertyName("expires_at")]
        [JsonConverter(typeof(UtcDateTimeUnixSecondsJsonConverter))]
        public DateTime? AccessTokenExpires { get; init; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; init; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; init; }
    }
}
