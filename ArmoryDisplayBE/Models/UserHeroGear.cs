namespace ArmoryDisplayBE.Models
{
    public class UserHeroGear
    {
        public int Id { get; set; }
        public int UserHeroId { get; set; }
        public int GearTypeId { get; set; }
        public int GearSetId { get; set; }
        public int Level { get; set; }
        public UserHero UserHero { get; set; } = null!;
        public GearType GearType { get; set; } = null!;
        public GearSet GearSet { get; set; } = null!;
        public List<UserHeroGearStats> UserHeroGearStats { get; set; } = [];
    }
}
