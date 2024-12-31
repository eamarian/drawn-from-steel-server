using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Skill
{
    enum SkillGroupEnum
    {
        CRAFTING = 1,
        EXPLORATION = 2,
        INTERPERSONAL = 3,
        INTRIGUE = 4,
        LORE = 5,
    }
    public class SkillGroup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(15)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(500)")]
        public required string Description { get; set; }

        public ICollection<Skill>? Skills { get; set; }

        public ICollection<SkillPool>? SkillPools { get; set; }
    }
}
