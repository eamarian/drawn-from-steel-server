using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Career
{
    public class CareerQuestion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required int CareerId { get; set; }
        public Career? Career { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Question { get; set; }
    }
}
