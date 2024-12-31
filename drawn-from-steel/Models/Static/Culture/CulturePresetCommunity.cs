using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Culture
{
    public class CulturePresetCommunity : CulturePreset
    {
        [Column(TypeName = "varchar(30)")]
        public required string Community { get; set; }
    }
}
