using DrawnFromSteel.Models.Static.Hero;

namespace DrawnFromSteel.Models.Static.Culture
{
    public class CulturePresetAncestry : CulturePreset
    {
        public required int AncestryId { get; set; }
        public Ancestry? Ancestry { get; set; }

        public required int LanguageId { get; set; }
        public Language? Language { get; set; }
    }
}
