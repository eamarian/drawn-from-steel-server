using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Skill
{
    enum SkillEnum
    {
        #region "CRAFTING"
        ALCHEMY = 01,
        ARCHITECTURE = 02,
        BLACKSMITHING = 03,
        CARPENTRY = 04,
        COOKING = 05,
        FLETCHING = 06,
        FORGERY = 07,
        JEWELRY = 08,
        MECHANICS = 09,
        TAILORING = 10,
        #endregion
        #region "EXPLORATION"
        CLIMB = 11,
        DRIVE = 12,
        ENDURANCE = 13,
        GYMNASTICS = 14,
        HEAL = 15,
        JUMP = 16,
        LIFT = 17,
        NAVIGATE = 18,
        RIDE = 19,
        SWIM = 20,
        #endregion
        #region "INTERPERSONAL"
        BRAG = 21,
        EMPATHIZE = 22,
        FLIRT = 23,
        GAMBLE = 24,
        HANDLE_ANIMALS = 25,
        INTERROGATE = 26,
        INTIMIDATE = 27,
        LEAD = 28,
        LIE = 29,
        MUSIC = 30,
        PERFORM = 31,
        PERSUADE = 32,
        READ_PERSON = 33,
        #endregion
        #region "INTRIGUE"
        ALERTNESS = 34,
        CONCEAL_OBJECT = 35,
        DISGUISE = 36,
        EAVESDROP = 37,
        ESCAPE_ARTIST = 38,
        HIDE = 39,
        PICK_LOCK = 40,
        PICK_POCKET = 41,
        SABOTAGE = 42,
        SEARCH = 43,
        SNEAK = 44,
        TRACK = 45,
        #endregion
        #region "LORE"
        CULTURE = 46,
        CRIMINAL_UNDERWORLD = 47,
        HISTORY = 48,
        MAGIC = 49,
        MONSTERS = 50,
        NATURE = 51,
        PSIONICS = 52,
        RELIGION = 53,
        RUMORS = 54,
        SOCIETY = 55,
        STRATEGY = 56,
        TIMESCAPE = 57,
        #endregion
    }
    public class Skill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Description { get; set; }

        public int SkillGroupId { get; set; }

        public SkillGroup? SkillGroup { get; set; }

        public ICollection<SkillPool>? SkillPools { get; set; }
    }
}
