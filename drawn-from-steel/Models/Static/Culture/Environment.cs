using DrawnFromSteel.Models.Static.Skill;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Culture
{
    enum EnvironmentEnum
    {
        NOMADIC = 1,
        RURAL = 2,
        SECLUDED = 3,
        URBAN = 4,
        WILDERNESS = 5,
    }

    public class Environment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(10)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public required string Description { get; set; }

        public required int SkillOptionId { get; set; }
        public SkillOption? SkillOption { get; set; }
    }
}
