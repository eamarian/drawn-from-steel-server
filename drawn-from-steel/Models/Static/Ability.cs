using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static
{
    public class Ability
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Description { get; set; }

        public required PowerRoll PowerRoll { get; set; }
    }
}
