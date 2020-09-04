using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarspearCalc
{
    public class GuardSkills
    {
        public int Autoattack = Convert.ToInt32(Character.RealDamage(Character.PhysicalDmg, Character.PhysicalDef) + (Character.RealDamage(Character.PhysicalDmg, Character.PhysicalDef) * Character.PowerAuto));

        public int StrongBeat(int SkillLevel)
        { 
            int Damage = Convert.ToInt32(Character.RealDamage((Character.PhysicalDmg * (1.01 + 0.2 * SkillLevel)) + (Character.Level * 2) + (SkillLevel * 15) + 10, Character.PhysicalDef));
            return Damage;
        }

        public int PowerfulLunge(int SkillLevel, int BonusDamage)
        {
            int Damage = Convert.ToInt32(Character.RealDamage((Character.PhysicalDmg * (0.85 + 0.05 * SkillLevel)) + (Character.Level * 2) + BonusDamage + 10, Character.PhysicalDef));
            return Damage;
        }

        public int ShieldThrow(int SkillLevel)
        {
            int Damage = Convert.ToInt32(Character.RealDamage((Character.PhysicalDmg * (0.8 + 0.1 * SkillLevel)) + (Character.Level * 2) + (10 + 5 * SkillLevel) + 30, Character.PhysicalDef));
            return Damage;
        }
    }
}
    