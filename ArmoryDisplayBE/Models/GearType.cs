namespace ArmoryDisplayBE.Models
{
    public class GearType
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int MainStatId { get; set; }
        public int MainStatValue { get; set; }
        public GearStats MainStat { get; set; } = null!;
    }
}
