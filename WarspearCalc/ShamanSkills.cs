using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarspearCalc
{
    public class ShamanSkills
    {
        public int Autoattack = Convert.ToInt32(Character.RealDamage(Character.MagicalDmg, Character.MagicalDef) + (Character.RealDamage(Character.MagicalDmg, Character.MagicalDef) * Character.PowerAuto));

        public int BallLightning(int SkillLevel)
        {
            int Damage = Convert.ToInt32(Character.RealDamage(((Character.MagicalDmg * (1.03 + 0.01 * SkillLevel)) + (Character.Level * 2) + (SkillLevel * 20) + 15), Character.MagicalDef));
            return Damage;
        }

        public int SpiritOfHealing(int SkillLevel)
        {
            int Heal = Convert.ToInt32(((Character.MagicalDmg * (0.7 + 0.4 * SkillLevel)) + (Character.Level * 3.5) + (150 + 30 * SkillLevel)) / 5);
            return Heal;
        }

        public int Earthquake(int SkillLevel, double BonusDamage)
        {
            int Damage = Convert.ToInt32(Character.RealDamage((Character.MagicalDmg * BonusDamage + Character.Level * 2 + SkillLevel * 10 + 10), Character.MagicalDef));
            return Damage;
        }

        public int LightningShield(int SkillLevel)
        {
            int Damage = Convert.ToInt32(Character.RealDamage(((Character.MagicalDmg * (0.98 + 0.02 * SkillLevel)) + (Character.Level * 2) + (SkillLevel * 20) + 30), Character.MagicalDef));
            return Damage;
        }
        
        public int FireTotem(int SkillLevel, int BonusDamage)
        {
            int Damage = Convert.ToInt32(Character.RealDamage(((Character.MagicalDmg * (0.8 + 0.1 * SkillLevel)) + (Character.Level * (1 + 2 * SkillLevel)) + BonusDamage), Character.MagicalDef));
            return Damage;
        }

        public int HealingTotem(int SkillLevel, int FixedBonusHeal, double FactorHeal, double BonusHeal)
        {
            int Heal = Convert.ToInt32((Character.MagicalDmg * BonusHeal) + (Character.Level * FactorHeal) + FixedBonusHeal);
            return Heal;
        }
    }
}
