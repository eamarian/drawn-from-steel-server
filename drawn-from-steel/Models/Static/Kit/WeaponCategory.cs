using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Kit
{
    enum WeaponCategoryEnum
    {
        BOW = 1,
        ENSNARING = 2,
        HEAVY = 3,
        LIGHT = 4,
        MEDIUM = 5,
        POLEARM = 6,
        UNARMED = 7,
        WHIP = 8,
    }
    public class WeaponCategory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        public required string Category { get; set; }

        [Column(TypeName = "varchar(500)")]
        public required string Description { get; set; }

        public ICollection<Kit>? Kits { get; set; }
    }
}
