using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Perk
{
    public class Perk
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required PerkType PerkType { get; set; }

        [Column(TypeName = "varchar(30)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Description { get; set; }
    }
}
