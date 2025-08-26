namespace ArmoryDisplayBE.Models
{
    public class GearSets
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int? BonusStatsId { get; set; }
        public int? BonusStatsValue { get; set; }
        public bool IsTwoPiece { get; set; }
        public Stat? BonusStats { get; set; }
    }
}
