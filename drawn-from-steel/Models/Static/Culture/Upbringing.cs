using DrawnFromSteel.Models.Static.Skill;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Culture
{
    enum UpbringingEnum
    {
        ACADEMIC = 1,
        CREATIVE = 2,
        ILLEGAL = 3,
        LABOR = 4,
        MARTIAL = 5,
        NOBLE = 6,
    }
    public class Upbringing
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(10)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(500)")]
        public required string Description { get; set; }

        public required int SkillOptionId { get; set; }
        public SkillOption? SkillOption { get; set; }
    }
}
