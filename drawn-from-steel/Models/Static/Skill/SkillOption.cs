using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Skill
{
    enum SkillOptionEnum
    {
        ENV_NOMADIC = 1,
        ENV_RURAL = 2,
        ENV_SECLUDED = 3,
        ENV_URBAN = 4,
        ENV_WILDERNESS = 5,
        ORG_ANARCHIC = 6,
        ORG_BUREAUCRATIC = 7,
        ORG_COMMUNAL = 8,
        UPB_ACADEMIC = 9,
        UPB_CREATIVE = 10,
        UPB_ILLEGAL = 11,
        UPB_LABOR = 12,
        UPB_MARTIAL = 13,
        UPB_NOBLE = 14,
        CAR_AGENT = 15,
        CAR_ARISTOCRAT = 16,
        CAR_ARTISAN = 17,
        CAR_BEGGAR = 18,
        CAR_CRIMINAL = 19,
        CAR_DISCIPLE = 20,
        CAR_EXPLORER = 21,
        CAR_FARMER = 22,
        CAR_GLADIATOR = 23,
        CAR_LABORER = 24,
        CAR_MAGES_APPRENTICE = 25,
        CAR_PERFORMER = 26,
        CAR_POLITICIAN = 27,
        CAR_SAGE = 28,
        CAR_SAILOR = 29,
        CAR_SOLDIER = 30,
        CAR_WARDEN = 31,
        CAR_WATCH_OFFICER = 32,
        CLS_CENSOR = 33,
        CLS_CONDUIT = 34,
        CLS_ELEMENTALIST = 35,
        CLS_FURY = 36,
        CLS_NULL = 37,
        CLS_SHADOW = 38,
        CLS_TACTICIAN = 39,
        CLS_TALENT = 40,
        CLS_TROUBADOUR = 41,
    }

    public class SkillOption
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Description { get; set; }

        public ICollection<SkillPool>? SkillPools { get; set; }
    }
}
