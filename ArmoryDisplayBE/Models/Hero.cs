namespace ArmoryDisplayBE.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int ConstellationId { get; set; }
        public int ElementId { get; set; }
        public int ClassId { get; set; }
        public int RarityId { get; set; }
        public Constellation Constellation { get; set; } = null!;
        public Element Element { get; set; } = null!;
        public HeroClass HeroClass { get; set; } = null!;
        public HeroRarity HeroRarity { get; set; } = null!;
        public List<User> Users { get; } = [];
    }
}
