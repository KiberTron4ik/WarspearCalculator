using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarspearCalc
{
    static class Character
    {
        public static double PhysicalDmg,
                             MagicalDmg,
                             Ferocity,
                             Penetration,
                             PhysicalDef,
                             MagicalDef,
                             Sustain,
                             Level,
                             PowerAuto;

        public static string IconName;

        public static double RealDamage(double dmg, double def)
        {
            double FixedPen = def - Penetration;

            if (FixedPen < 0)
                FixedPen = 0;

            double DmgWithPen = dmg - (dmg * FixedPen);
            double DmgWithSustain = DmgWithPen - (DmgWithPen * Sustain);
            double RealDamage = DmgWithSustain + (DmgWithSustain * Ferocity);
            return RealDamage;
        }
    }
}