using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Kit
{
    enum KitEnum
    {
        ARCANE_ARCHER = 1,
        BATTLEMIND = 2,
        CLOAK_AND_DAGGER = 3,
        DUAL_WIELDER = 4,
        GUISARMIER = 5,
        MARTIAL_ARTIST = 6,
        MOUNTAIN = 7,
        PANTHER = 8,
        PUGILIST = 9,
        RAIDER = 10,
        RANGER = 11,
        RAPID_FIRE = 12,
        RETIARIUS = 13,
        SHINING_ARMOR = 14,
        SNIPER = 15,
        SPELLSWORD = 16,
        STICK_AND_ROBE = 17,
        SWASHBUCKLER = 18,
        SWORD_AND_BOARD = 19,
        WARRIOR_PRIEST = 20,
        WHIRLWIND = 21
    }
    public class Kit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(500)")]
        public required string Description { get; set; }

        public ICollection<ArmorCategory>? ArmorCategories { get; set; }

        public ICollection<WeaponCategory>? WeaponCategories { get; set; }

        public int StaminaBonusPerEchelon { get; set; } = 0;

        public int SpeedBonus { get; set; } = 0;

        public int StabilityBonus { get; set; } = 0;

        //public DamageBonus MeleeDamageBonus { get; set; } = new DamageBonus(0, 0, 0);
        public int MeleeDamageBonusTier1 { get; set; } = 0;
        public int MeleeDamageBonusTier2 { get; set; } = 0;
        public int MeleeDamageBonusTier3 { get; set; } = 0;

        //public DamageBonus RangedDamageBonus { get; set; } = new DamageBonus(0, 0, 0);
        public int RangedDamageBonusTier1 { get; set; } = 0;
        public int RangedDamageBonusTier2 { get; set; } = 0;
        public int RangedDamageBonusTier3 { get; set; } = 0;


        public int RangedDistanceBonus { get; set; } = 0;

        public int MeleeDistanceBonus { get; set; } = 0;

        public int DisengageBonus { get; set; } = 0;

        //public required Ability SignatureAbility { get; set; }
    }
}
