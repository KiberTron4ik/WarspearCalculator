using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarspearCalc
{
    public class BladeDancerSkills
    {
        public int Autoattack = Convert.ToInt32(Stats.Damage(Stats.PhysicalDmg, Stats.PhysicalDef));

        public int LightningStrike(int SkillLevel)
        {
            int Damage = Convert.ToInt32(Stats.Damage((Stats.PhysicalDmg * (1.02 + 0.02 * SkillLevel) + (Stats.Level * 2) + (SkillLevel * 15) + 25), Stats.PhysicalDef));
            return Damage;
        }

        public int Undercut(int SkillLevel)
        {
            int Damage = Convert.ToInt32(Stats.Damage((Stats.PhysicalDmg * (1 + 0.02 * SkillLevel) + (Stats.Level * 2) + (SkillLevel * 15) + 5) / 3, Stats.PhysicalDef));
            return Damage;
        }

        public int SonicWave(int SkillLevel, int FixedBonusDamage)
        {
            int Damage = Convert.ToInt32(Stats.Damage((Stats.PhysicalDmg * (0.83 + 0.07 * SkillLevel) + (Stats.Level * (1 + 1 * SkillLevel)) + FixedBonusDamage + 45), Stats.PhysicalDef));
                return Damage;
        }
    }
}
