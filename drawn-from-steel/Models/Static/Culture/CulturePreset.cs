using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Culture
{
    public abstract class CulturePreset
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required int EnvironmentId { get; set; }
        public Environment? Environment { get; set; }

        public required int OrganizationId { get; set; }
        public Organization? Organization { get; set; }

        public required int UprbringingId { get; set; }
        public Upbringing? Upbringing { get; set; }
    }
}
