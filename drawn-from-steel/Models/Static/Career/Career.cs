using DrawnFromSteel.Models.Static.Perk;

using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Career
{
    enum CareerEnum
    {
        AGENT = 1,
        ARISTOCRAT = 2,
        ARTISAN = 3,
        BEGGAR = 4,
        CRIMINAL = 5,
        DISCIPLE = 6,
        EXPLORER = 7,
        FARMER = 8,
        GLADIATOR = 9,
        LABORER = 10,
        MAGES_APPRENTICE = 11,
        PERFORMER = 12,
        POLITICIAN = 13,
        SAGE = 14,
        SAILOR = 15,
        SOLDIER = 16,
        WARDEN = 17,
        WATCH_OFFICER = 18,
    }
    public class Career
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(300)")]
        public required string Description { get; set; }

        public int LanguageBonus { get; set; } = 0;

        public int RenownBonus { get; set; } = 0;

        public int WealthBonus { get; set; } = 1;

        public int ProjectPointBonus { get; set; } = 0;

        public required int PerkTypeId { get; set; }
        public PerkType? PerkType { get; set; }

        public required int SkillOptionId { get; set; }
        public Skill.SkillOption? SkillOption { get; set; }

        public ICollection<IncitingIncident>? IncitingIncidents { get; set; }
    }
}
