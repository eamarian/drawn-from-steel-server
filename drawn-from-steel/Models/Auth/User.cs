using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Auth
{
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string? Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string? Email { get; set; }

        public DateTime? EmailVerified { get; set; }

        public string? Image { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Account> Accounts { get; set; } = new List<Account>();

        public ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}
