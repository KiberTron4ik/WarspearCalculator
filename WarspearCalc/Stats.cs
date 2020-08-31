using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarspearCalc
{
    static class Stats
    {
        public static double PhysicalDmg,
                            MagicalDmg,
                            Ferocity,
                            Penetration,
                            PhysicalDef,
                            MagicalDef,
                            Sustain,
                            Level;
        public static string IconName;

        public static int Damage(double _dmg, double _def)
        {
            double FixedPen = _def - Penetration;

            if (FixedPen < 0)
                FixedPen = 0;

            int FixedPVEDmg = Convert.ToInt32(_dmg - (_dmg * FixedPen));
            int PVPDmg = Convert.ToInt32(FixedPVEDmg - (FixedPVEDmg * Sustain));
            int FixedPVPDmg = Convert.ToInt32(PVPDmg + (PVPDmg * Ferocity));
            return FixedPVPDmg;
        }

    }
}