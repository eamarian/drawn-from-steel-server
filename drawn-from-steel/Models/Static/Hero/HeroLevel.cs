using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Hero
{
    public class HeroLevel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Level { get; set; }

        public required int HeroLevelEchelonId { get; set; }

        public HeroLevelEchelon? Echelon { get; set; }

        public required int XPThreshhold { get; set; }
    }
}
