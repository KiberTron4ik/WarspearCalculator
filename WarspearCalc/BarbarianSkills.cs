using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarspearCalc
{
    public class BarbarianSkills
    {
        public int Autoattack = Convert.ToInt32(Character.RealDamage(Character.PhysicalDmg, Character.PhysicalDef) + (Character.RealDamage(Character.PhysicalDmg, Character.PhysicalDef) * Character.PowerAuto));

        public int StrongBlow(int SkillLevel)
        {
            int Damage = Convert.ToInt32(Character.RealDamage((Character.PhysicalDmg * (1.01 + 0.02 * SkillLevel)) + 2 * Character.Level + 10 + (15 * SkillLevel), Character.PhysicalDef));
            return Damage;
        }

        public int Choap(int SkillLevel, double BonusDamage)
        {
            int Damage = Convert.ToInt32(Character.RealDamage((Character.PhysicalDmg * 0.075) + (3 * SkillLevel) + 2 + (Character.Level / 2), Character.PhysicalDef));
            return Damage;
        }

        public int Charge(int SkillLevel)
        {
            int Damage = Convert.ToInt32(((10 * SkillLevel) + (3 * Character.Level) + ((-0.02 + 0.12 * SkillLevel) * Character.PhysicalDmg)));
            return Damage;
        }

        public int ShieldBash(int SkillLevel)
        {
            int Damage = Convert.ToInt32(Character.RealDamage(25 + (2 * Character.Level) + (-30 + 15 * SkillLevel) + ((1.07 + 0.04 * SkillLevel) * Character.PhysicalDmg), Character.PhysicalDef));
            return Damage;
        }

        public int Defeat(int SkillLevel, double BonusDamage)
        {
            int Damage = Convert.ToInt32(Character.RealDamage((2 * Character.Level) + (0 + 10 * SkillLevel) + (BonusDamage * Character.PhysicalDmg), Character.PhysicalDef));
            return Damage;
        }
    }
}
