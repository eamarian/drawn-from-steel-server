using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Trait
{
    public abstract class Trait
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public required string Name { get; set; }


        [Column(TypeName = "varchar(500)")]
        public required string Description { get; set; }
    }
}
