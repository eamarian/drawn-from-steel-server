using DrawnFromSteel.Models.Static.Trait;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Hero
{
    enum AncestryEnum
    {
        DEVIL = 1,
        DRAGON_KNIGHT = 2,
        DWARF = 3,
        ELF_WODE = 4,
        ELF_HIGH = 5,
        HAKAAN = 6,
        HUMAN = 7,
        MEMONEK = 8,
        ORC = 9,
        POLDER = 10,
        REVENANT = 11,
        TIME_RAIDER = 12,
    }

    public class Ancestry
    {
        private const int DEFAULT_SPEED = 5;
        private const int DEFAULT_STABILITY = 0;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(15)")]
        public required string Type { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SubType { get; set; } = string.Empty;

        [Column(TypeName = "varchar(255)")]
        public required string Description { get; set; }
        // Not currently using Size complex type because seeding is not currently supported for complex types
        //public Size Size { get; set; } = new Size(1, SizeModifier.Medium);
        //public bool ShowSize { get => Size.IsDefault; }
        public required int MinHeightInches { get; set; }
        public required int MaxHeightInches { get; set; }
        public required int MinWeightPounds { get; set; }
        public required int MaxWeightPounds { get; set; }
        public required int MinLifeExpectancyYears { get; set; }
        public required int MaxLifeExpectancyYears { get; set; }
        public int SizeSquares { get; set; } = Size.DEFAULT_SQUARES;
        public SizeModifier SizeModifier { get; set; } = Size.DEFAULT_SIZE_MODIFIER;
        public Size Size { get => new Size(SizeSquares, SizeModifier); }
        public bool ShowSize { get => !new Size(SizeSquares, SizeModifier).IsDefault; }
        public int Speed { get; set; } = DEFAULT_SPEED;
        public bool ShowSpeed { get => Speed != DEFAULT_SPEED; }
        public int Stability { get; set; } = DEFAULT_STABILITY;
        public required int Points { get; set; }
        ICollection<SignatureAncestryTrait>? SignatureAncestryTraits { get; set; }
        ICollection<PurchasedAncestryTrait>? PurchasedAncestryTraits { get; set; }
    }
}
