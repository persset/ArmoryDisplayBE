namespace ArmoryDisplayBE.Models
{
    public class UserHeroGearStats
    {
        public int Id { get; set; }
        public int UserHeroGearId { get; set; }
        public int GearStatsId { get; set; }
        public int Value { get; set; }
        public bool IsMainStat { get; set; }
        public bool IsPercent { get; set; }

        public UserHeroGear UserHeroGear { get; set; } = null!;
        public GearStats GearStats { get; set; } = null!;
    }
}
