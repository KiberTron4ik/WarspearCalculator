using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarspearCalc
{
    public class BladeDancerSkills
    {
        public int Autoattack = Convert.ToInt32(Character.RealDamage(Character.PhysicalDmg, Character.PhysicalDef) + (Character.RealDamage(Character.PhysicalDmg, Character.PhysicalDef) * Character.PowerAuto));

        public int LightningStrike(int SkillLevel)
        {
            int Damage = Convert.ToInt32(Character.RealDamage((Character.PhysicalDmg * (1.02 + 0.02 * SkillLevel) + (Character.Level * 2) + (SkillLevel * 15) + 25), Character.PhysicalDef));
            return Damage;
        }

        public int Undercut(int SkillLevel)
        {
            int Damage = Convert.ToInt32(Character.RealDamage((Character.PhysicalDmg * (1 + 0.02 * SkillLevel) + (Character.Level * 2) + (SkillLevel * 15) + 5) / 3, Character.PhysicalDef));
            return Damage;
        }

        public int SonicWave(int SkillLevel, int FixedBonusDamage)
        {
            int Damage = Convert.ToInt32(Character.RealDamage((Character.PhysicalDmg * (0.83 + 0.07 * SkillLevel) + (Character.Level * (1 + 1 * SkillLevel)) + FixedBonusDamage + 45), Character.PhysicalDef));
                return Damage;
        }
    }
}
