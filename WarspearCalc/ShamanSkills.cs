using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarspearCalc
{
    public class ShamanSkills
    {
        public  int Autoattack = Convert.ToInt32(Stats.Damage(Stats.MagicalDmg, Stats.MagicalDef));

        public  int BallLightning(int SkillLevel)
        {
            int Damage = Convert.ToInt32(Stats.Damage(((Stats.MagicalDmg * (1.03 + 0.01 * SkillLevel)) + (Stats.Level * 2) + (SkillLevel * 20) + 15), Stats.MagicalDef));
            return Damage;
        }

        public  int SpiritOfHealing(int SkillLevel)
        {
            int Heal = Convert.ToInt32(((Stats.MagicalDmg * (0.7 + 0.4 * SkillLevel)) + (Stats.Level * 3.5) + (150 + 30 * SkillLevel)) / 5);
            return Heal;
        }

        public  int Earthquake(int SkillLevel, double BonusDamage)
        {
            int Damage = Convert.ToInt32(Stats.Damage((Stats.MagicalDmg * BonusDamage + Stats.Level * 2 + SkillLevel * 10 + 10), Stats.MagicalDef));
            return Damage;
        }

        public  int LightningShield(int SkillLevel)
        {
            int Damage = Convert.ToInt32(Stats.Damage(((Stats.MagicalDmg * (0.98 + 0.02 * SkillLevel)) + (Stats.Level * 2) + (SkillLevel * 20) + 30), Stats.MagicalDef));
            return Damage;
        }
        
        public  int FireTotem(int SkillLevel, int BonusDamage)
        {
            int Damage = Convert.ToInt32(Stats.Damage(((Stats.MagicalDmg * (0.8 + 0.1 * SkillLevel)) + (Stats.Level * (1 + 2 * SkillLevel)) + BonusDamage), Stats.MagicalDef));
            return Damage;
        }

        public  int HealingTotem(int SkillLevel, int FixedBonusHeal, double FactorHeal, double BonusHeal)
        {
            int Heal = Convert.ToInt32((Stats.MagicalDmg * BonusHeal) + (Stats.Level * FactorHeal) + FixedBonusHeal);
            return Heal;
        }
    }
}
