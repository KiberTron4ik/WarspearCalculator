using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarspearCalc
{
    public class BarbarianSkills
    {
        public int Autoattack = Convert.ToInt32(Stats.Damage(Stats.PhysicalDmg, Stats.PhysicalDef));

        public int StrongBlow(int SkillLevel)
        {
            int Damage = Convert.ToInt32(Stats.Damage((Stats.PhysicalDmg * (1.01 + 0.02 * SkillLevel)) + 2 * Stats.Level + 10 + (15 * SkillLevel), Stats.PhysicalDef));
            return Damage;
        }

        public int Choap(int SkillLevel, double BonusDamage)
        {
            int Damage = Convert.ToInt32(Stats.Damage((Stats.PhysicalDmg * 0.075) + (3 * SkillLevel) + 2 + (Stats.Level / 2), Stats.PhysicalDef));
            return Damage;
        }

        public int Charge(int SkillLevel)
        {
            int Damage = Convert.ToInt32(((10 * SkillLevel) + (3 * Stats.Level) + ((-0.02 + 0.12 * SkillLevel) * Stats.PhysicalDmg)));
            return Damage;
        }

        public int ShieldBash(int SkillLevel)
        {
            int Damage = Convert.ToInt32(Stats.Damage(25 + (2 * Stats.Level) + (-30 + 15 * SkillLevel) + ((1.07 + 0.04 * SkillLevel) * Stats.PhysicalDmg), Stats.PhysicalDef));
            return Damage;
        }

        public int Defeat(int SkillLevel, double BonusDamage)
        {
            int Damage = Convert.ToInt32(Stats.Damage((2 * Stats.Level) + (0 + 10 * SkillLevel) + (BonusDamage * Stats.PhysicalDmg), Stats.PhysicalDef));
            return Damage;
        }
    }
}
