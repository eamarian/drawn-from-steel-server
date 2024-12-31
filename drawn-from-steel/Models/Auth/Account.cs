using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Auth
{
    [Index(nameof(ProviderAccountId), nameof(ProviderId))]
    public class Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required User User { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string ProviderType { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string ProviderId { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string ProviderAccountId { get; set; }

        public string? RefreshToken { get; set; }

        public string? AccessToken { get; set; }

        public DateTime? AccessTokenExpires { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }
    }
}
