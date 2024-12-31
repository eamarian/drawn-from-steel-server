using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Kit
{
    enum ArmorCategoryEnum
    {
        NONE = 1,
        LIGHT = 2,
        MEDIUM = 3,
        HEAVY = 4,
        SHIELD = 5,
    }
    public class ArmorCategory
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
