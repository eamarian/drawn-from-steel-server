using DrawnFromSteel.Models.Static.Hero;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static
{
    [ComplexType]
    public record PowerRoll
    {
        ICollection<Characteristic>? Characteristics { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Tier1Result { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Tier2Result { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Tier3Result { get; set; }

    }
}
