using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Career
{
    public class IncitingIncident
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(500)")]
        public required string Description { get; set; }

        public required int CareerId { get; set; }
        public Career? Career { get; set; }
    }
}
