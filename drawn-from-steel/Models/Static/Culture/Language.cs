using System.ComponentModel.DataAnnotations.Schema;

namespace DrawnFromSteel.Models.Static.Culture
{
    enum LanguageEnum
    {
        ANJALI = 1,
        AXIOMATIC = 2,
        CAELIAN = 3,
        FILLIARIC = 4,
        HIGH_KURIC = 5,
        HYRALLIC = 6,
        ILLYVRIC = 7,
        KALLIAK = 8,
        KETHAIC = 9,
        KHELT = 10,
        KHOURSIRIAN = 11,
        LOW_KURIC = 12,
        MINDSPEECH = 13,
        PROTO_CTHOLL = 14,
        SZETCH = 15,
        THE_FIRST_LANGUAGE = 16,
        THOLL = 17,
        UROLLIALIC = 18,
        VARIAC = 19,
        VASTARIAX = 20,
        VHORIC = 21,
        VOLL = 22,
        YLLYRIC = 23,
        ZAHARIAX = 24,
        ZALIAC = 25,
        UVALIC = 26,
        HIGARAN = 27,
        OAXUATL = 28,
        KHEMHARIC = 29,
        PHAEDRAN = 31,
        RIOJAN = 32,
        VANIRIC = 33,
        VASLORIAN = 34,
        HIGH_RHYVIAN = 35,
        KHAMISH = 36,
        KHELTIVARI = 37,
        LOW_RHIVIAN = 38,
        OLD_VARIAC = 39,
        PHORIALTIC = 40,
        RALLARIAN = 41,
        ULLORVIC = 42,
    }
    public class Language
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Description { get; set; }
    }
}
