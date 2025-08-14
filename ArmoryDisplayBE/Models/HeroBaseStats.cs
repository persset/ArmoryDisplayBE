using System.Numerics;

namespace ArmoryDisplayBE.Models
{
    public class HeroBaseStats
    {
        public int ConstellationId { get; set; }
        public int ClassId { get; set; }
        public int RarityId { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public double CriticalHitChance { get; set; }
        public int CriticalHitDamage { get; set; }
        public double Effectiveness { get; set; }
        public double EffectResistance { get; set; }
        public double DualAttackChance { get; set; }
    }
}
