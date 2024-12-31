using DrawnFromSteel.Models.Static.Skill;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Culture
{
    enum OrganizationEnum
    {
        ANARCHIC = 1,
        BUREAUCRATIC = 2,
        COMMUNAL = 3,
    }
    public class Organization
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(15)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(1500)")]
        public required string Description { get; set; }

        public required int SkillOptionId { get; set; }
        public SkillOption? SkillOption { get; set; }
    }
}
