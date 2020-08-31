using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarspearCalc
{
    public partial class BarbarianForm : Form
    {
        BarbarianSkills barbskills = new BarbarianSkills();

        public BarbarianForm()
        {
            InitializeComponent();
        }

        private void BarbarianForm_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(barbskills.StrongBlow(1));
            label2.Text = Convert.ToString(barbskills.Choap(1, 1) + " за тик");
            label3.Text = Convert.ToString(barbskills.Charge(1));
            label4.Text = Convert.ToString(barbskills.ShieldBash(1));
            label5.Text = Convert.ToString(barbskills.Defeat(1, 0.8) + " / " + Convert.ToInt32((barbskills.Defeat(1, 0.8) * 1.2)));
            label6.Text = Convert.ToString("Автоатака: " + barbskills.Autoattack);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int SkillLevel = trackBar1.Value;
            label1.Text = Convert.ToString(barbskills.StrongBlow(SkillLevel));
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            double BonusDamage = 1;
            int SkillLevel = trackBar2.Value;
            switch (SkillLevel)
            {
                case 1:
                    BonusDamage = 1;
                    break;
                case 2:
                    BonusDamage = 1.4;
                    break;
                case 3:
                    BonusDamage = 2.12;
                    break;
                case 4:
                    BonusDamage = 2.51;
                    break;
                case 5:
                    BonusDamage = 2.88;
                    break;
            }
            label2.Text = Convert.ToString(barbskills.Choap(SkillLevel, BonusDamage)) + " за тик";
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int SkillLevel = trackBar3.Value;
            label3.Text = Convert.ToString(barbskills.Charge(SkillLevel));
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            int SkillLevel = trackBar4.Value;
            label4.Text = Convert.ToString(barbskills.ShieldBash(SkillLevel));
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            double BonusDamage = 0.8;
            double ComboBonus = 1.2;
            int SkillLevel = trackBar5.Value;
            switch (SkillLevel)
            {
                case 1:
                    BonusDamage = 0.8;
                    ComboBonus = 1.2;
                    break;
                case 2:
                    BonusDamage = 1;
                    ComboBonus = 1.3;
                    break;
                case 3:
                    BonusDamage = 1.15;
                    ComboBonus = 1.45;
                    break;
                case 4:
                    BonusDamage = 1.3;
                    ComboBonus = 1.6;
                    break;
            }
            label5.Text = Convert.ToString(barbskills.Defeat(SkillLevel, BonusDamage) + " / " + Convert.ToInt32((barbskills.Defeat(SkillLevel, BonusDamage) * ComboBonus)));
        }
    }
}
