namespace ArmoryDisplayBE.Models
{
    public class GearSets
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int? BonusStatsId { get; set; }
        public int? BonusStatsValue { get; set; }
        public bool IsTwoPiece { get; set; }
        public Stats? BonusStats { get; set; }
    }
}
