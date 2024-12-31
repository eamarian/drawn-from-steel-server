using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Perk
{
    enum PerkTypeEnum
    {
        CRAFTING = 1,
        EXPLORATION = 2,
        INTERPERSONAL = 3,
        INTRIGUE = 4,
        LORE = 5,
        SUPERNATURAL = 6,
    }
    public class PerkType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(15)")]
        public required string Type { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Description { get; set; }

    }
}
