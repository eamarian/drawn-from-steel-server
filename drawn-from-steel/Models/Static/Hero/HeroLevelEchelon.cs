using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Hero
{
    public class HeroLevelEchelon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required int Echelon { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public required string Description { get; set; }
    }
}
