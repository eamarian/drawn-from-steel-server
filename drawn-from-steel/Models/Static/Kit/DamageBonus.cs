using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Kit
{
    [ComplexType]
    public record DamageBonus(int Tier1, int Tier2, int Tier3)
    {
        public int Tier1 { get; init; } = Tier1;
        public int Tier2 { get; init; } = Tier2;
        public int Tier3 { get; init; } = Tier3;

    }
}
