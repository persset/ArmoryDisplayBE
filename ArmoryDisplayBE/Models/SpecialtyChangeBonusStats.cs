using System.Numerics;

namespace ArmoryDisplayBE.Models
{
    public class SpecialtyChangeBonusStats
    {
        public int HeroId { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public double CriticalHitChance { get; set; }
        public int CriticalHitDamage { get; set; }
        public double Effectiveness { get; set; }
        public double EffectResistance { get; set; }
        public double DualAttackChance { get; set; }
        public Hero Hero { get; set; } = null!;
    }
}
