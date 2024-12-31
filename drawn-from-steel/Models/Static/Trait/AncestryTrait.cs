using DrawnFromSteel.Models.Static.Hero;

namespace DrawnFromSteel.Models.Static.Trait
{
    public abstract class AncestryTrait : Trait
    {
        public Ancestry? Ancestry { get; set; }
        public required int AncestryId { get; set; }
    }
}
