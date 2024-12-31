using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Hero
{
    enum CharacteristicEnum
    {
        MIGHT = 1,
        AGILITY = 2,
        REASON = 3,
        INTUITION = 4,
        PRESENCE = 5
    }

    public class Characteristic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(10)")]
        public required string Name { get; set; }

        public required char Short { get; set; }


        [Column(TypeName = "varchar(300)")]
        public required string Description { get; set; }

    }
}
