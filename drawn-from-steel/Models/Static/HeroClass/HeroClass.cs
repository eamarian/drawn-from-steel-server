using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.HeroClass
{
    enum HeroClassEnum
    {
        CENSOR = 1,
        CONDUIT = 2,
        ELEMENTALIST = 3,
        FURY = 4,
        NULL = 5,
        SHADOW = 6,
        TACTICIAN = 7,
        TALENT = 8,
        TROUBADOUR = 9,
    }
    public class HeroClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(15)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(500)")]
        public required string Description { get; set; }
    }
}
