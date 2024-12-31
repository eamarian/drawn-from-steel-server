using System.Text.Json.Serialization;

namespace DrawnFromSteel.DTOs.Auth.User
{
    public record UserCreateRequest
    {

        [JsonPropertyName("name")]
        public string? Name { get; init; }

        [JsonPropertyName("email")]
        public string? Email { get; init; }

        [JsonPropertyName("email_verified")]
        public DateTime? EmailVerified { get; init; }

        [JsonPropertyName("image")]
        public string? Image { get; init; }
    }
}
