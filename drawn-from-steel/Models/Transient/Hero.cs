namespace DrawnFromSteel.Models.Transient
{
    public class Hero
    {
        public int Id { get; set; }
        public required Auth.User User { get; set; }
        public string Name { get; set; } = string.Empty;
        //public Ancestry? Ancestry { get; set; }
        //public Culture? Culture { get; set; }
        //public Career? Career { get; set; }
        public int Level { get; set; }
    }
}
