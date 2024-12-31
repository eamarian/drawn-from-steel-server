using DrawnFromSteel.Converters;
using System.Text.Json.Serialization;

namespace DrawnFromSteel.DTOs.Auth.Account
{
    public record AccountCreateRequest
    {
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

        [JsonPropertyName("token_type")]
        public string? TokenType { get; init; }

        [JsonPropertyName("scope")]
        public string? Scope { get; init; }

        [JsonPropertyName("id_token")]
        public string? IdToken { get; init; }
    }
}
