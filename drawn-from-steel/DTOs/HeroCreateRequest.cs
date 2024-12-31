using System.Text.Json.Serialization;

namespace DrawnFromSteel.DTOs
{
    public record HeroCreateRequest
    {
        [JsonPropertyName("id")]
        public required int Id { get; init; }

        [JsonPropertyName("userId")]
        public required int UserId { get; init; }

        [JsonPropertyName("name")]
        public required string Name { get; init; }

        [JsonPropertyName("level")]
        public int Level { get; init; }

        [JsonPropertyName("image")]
        public string? Image { get; init; }
    }
}
