using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Skill
{
    enum SkillPoolEnum
    {
        ENV_NOMADIC = 01,
        ENV_RURAL = 02,
        ENV_SECLUDED = 03,
        ENV_URBAN = 04,
        ENV_WILDERNESS = 05,
        ORG_ANARCHIC = 06,
        ORG_BUREAUCRATIC = 07,
        ORG_COMMUNAL = 08,
        UPB_ACADEMIC = 09,
        UPB_CREATIVE = 10,
        UPB_ILLEGAL = 11,
        UPB_LABOR = 12,
        UPB_MARTIAL = 13,
        UPB_NOBLE = 14,
        CAR_AGENT_1 = 15,
        CAR_AGENT_2 = 16,
        CAR_AGENT_3 = 17,
        CAR_ARISTOCRAT_1 = 18,
        CAR_ARISTOCRAT_2 = 19,
        CAR_ARTISAN = 20,
        CAR_BEGGAR_1 = 21,
        CAR_BEGGAR_2 = 22,
        CAR_BEGGAR_3 = 23,
        CAR_CRIMINAL_1 = 24,
        CAR_CRIMINAL_2 = 25,
        CAR_DISCIPLE_1 = 26,
        CAR_DISCIPLE_2 = 27,
        CAR_EXPLORER_1 = 28,
        CAR_EXPLORER_2 = 29,
        CAR_FARMER_1 = 30,
        CAR_FARMER_2 = 31,
        CAR_GLADIATOR = 32,
        CAR_LABORER_1 = 33,
        CAR_LABORER_2 = 34,
        CAR_MAGESAPPRENTICE_1 = 35,
        CAR_MAGESAPPRENTICE_2 = 36,
        CAR_PERFORMER_1 = 37,
        CAR_PERFORMER_2 = 38,
        CAR_POLITICIAN = 39,
        CAR_SAGE = 40,
        CAR_SAILOR_1 = 41,
        CAR_SAILOR_2 = 42,
        CAR_SOLDIER_1 = 43,
        CAR_SOLDIER_2 = 44,
        CAR_WARDEN_1 = 45,
        CAR_WARDEN_2 = 46,
        CAR_WARDEN_3 = 47,
        CAR_WATCH_OFFICER_1 = 48,
        CAR_WATCH_OFFICER_2 = 49,
        CLS_CENSOR = 50,
        CLS_CONDUIT = 51,
        CLS_ELEMENTALIST_1 = 52,
        CLS_ELEMENTALIST_2 = 53,
        CLS_FURY_1 = 54,
        CLS_FURY_2 = 55,
        CLS_NULL_1 = 56,
        CLS_NULL_2 = 57,
        CLS_SHADOW_1 = 58,
        CLS_SHADOW_2 = 59,
        CLS_TACTICIAN_1 = 60,
        CLS_TACTICIAN_2 = 61,
        CLS_TALENT_1 = 62,
        CLS_TALENT_2 = 63,
        CLS_TROUBADOUR_1 = 64,
        CLS_TROUBADOUR_2 = 65,
        CLS_TROUBADOUR_3 = 66,
    }
    public class SkillPool
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        public required string Name { get; set; }

        public ICollection<SkillOption>? SkillOptions { get; set; }

        public ICollection<SkillGroup>? SkillGroups { get; set; }

        public ICollection<Skill>? Skills { get; set; }
    }
}
