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
    public partial class ShamanForm : Form
    {
        ShamanSkills shamskills = new ShamanSkills();
        public ShamanForm()
        {
            InitializeComponent();
        }

        private void ShamanForm_Load(object sender, EventArgs e)
        {
            
            label1.Text = Convert.ToString(shamskills.BallLightning(1));
            label2.Text = Convert.ToString(shamskills.SpiritOfHealing(1) + " за тик");
            label3.Text = Convert.ToString(shamskills.Earthquake(1, 0.9));
            label4.Text = Convert.ToString(shamskills.LightningShield(1));
            label5.Text = Convert.ToString(shamskills.FireTotem(1, 10) + " за тик");
            label6.Text = Convert.ToString("Автоатака: " + shamskills.Autoattack);
            label7.Text = Convert.ToString(shamskills.HealingTotem(1, 120, 2.5, 0.2) + " за тик");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int SkillLevel = trackBar1.Value;
            label1.Text = Convert.ToString(shamskills.BallLightning(SkillLevel));
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int SkillLevel = trackBar2.Value;
            label2.Text = Convert.ToString(shamskills.SpiritOfHealing(SkillLevel) + " за тик");
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            double BonusDamage = 0.9;
            int SkillLevel = trackBar3.Value;
            switch (SkillLevel)
            {
                case 1:
                    BonusDamage = 0.9;
                    break;
                case 2:
                    BonusDamage = 1;
                    break;
                case 3:
                    BonusDamage = 1.01;
                    break;
                case 4:
                    BonusDamage = 1.02;
                    break;
                case 5:
                    BonusDamage = 1.03;
                    break;
            }
            label3.Text = Convert.ToString(shamskills.Earthquake(SkillLevel, BonusDamage));
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            int SkillLevel = trackBar4.Value;
            label4.Text = Convert.ToString(shamskills.LightningShield(SkillLevel));
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            int BonusDamage = 10;
            int SkillLevel = trackBar5.Value;
            switch (SkillLevel)
            {
                case 1:
                    BonusDamage = 10;
                    break;
                case 2:
                    BonusDamage = 25;
                    break;
                case 3:
                    BonusDamage = 50;
                    break;
                case 4:
                    BonusDamage = 70;
                    break;
            }
            label5.Text = Convert.ToString(shamskills.FireTotem(SkillLevel, BonusDamage) + " за тик");
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            int FixedBonusHeal = 120;
            double FactorHeal = 2.5;
            double BonusHeal = 0.2;
            int SkillLevel = trackBar6.Value;
            switch (SkillLevel)
            {
                case 1:
                    FixedBonusHeal = 120;
                    FactorHeal = 2.5;
                    BonusHeal = 0.2;
                    break;
                case 2:
                    FixedBonusHeal = 150;
                    FactorHeal = 3;
                    BonusHeal = 0.3;
                    break;
                case 3:
                    FixedBonusHeal = 180;
                    FactorHeal = 4;
                    BonusHeal = 0.35;
                    break;
                case 4:
                    FixedBonusHeal = 220;
                    FactorHeal = 5;
                    BonusHeal = 0.45;
                    break;
            }
            label7.Text = Convert.ToString(shamskills.HealingTotem(SkillLevel, FixedBonusHeal, FactorHeal, BonusHeal) + " за тик");
        }
    }
}
