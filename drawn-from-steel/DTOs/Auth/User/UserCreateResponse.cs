using System.Text.Json.Serialization;

namespace DrawnFromSteel.DTOs.Auth.User
{
    public record UserCreateResponse
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
