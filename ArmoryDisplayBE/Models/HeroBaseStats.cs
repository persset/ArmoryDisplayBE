namespace ArmoryDisplayBE.Models
{
    public class HeroBaseStats
    {
        public int Id { get; set; }
        public int ConstellationId { get; set; }
        public int HeroClassId { get; set; }
        public int HeroRarityId { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public double CriticalHitChance { get; set; }
        public int CriticalHitDamage { get; set; }
        public double Effectiveness { get; set; }
        public double EffectResistance { get; set; }
        public double DualAttackChance { get; set; }
        public Constellation Constellation { get; set; } = null!;
        public HeroClass HeroClass { get; set; } = null!;
        public HeroRarity HeroRarity { get; set; } = null!;
    }
}
