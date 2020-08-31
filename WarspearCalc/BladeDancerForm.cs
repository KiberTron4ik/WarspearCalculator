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
    public partial class BladeDancerForm : Form
    {
        BladeDancerSkills bdskills = new BladeDancerSkills();
        public BladeDancerForm()
        {
            InitializeComponent();
        }

        private void BladeDancerForm_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(bdskills.LightningStrike(1));
            label2.Text = Convert.ToString(bdskills.Undercut(1) + " за тик");
            label3.Text = Convert.ToString(bdskills.SonicWave(1, 15) + "/" + Convert.ToInt32(bdskills.SonicWave(1, 15) / 3));
            label4.Text = Convert.ToString("Автоатака: " + bdskills.Autoattack);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int SkillLevel = trackBar1.Value;
            label1.Text = Convert.ToString(bdskills.LightningStrike(SkillLevel));
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int SkillLevel = trackBar2.Value;
            label2.Text = Convert.ToString(bdskills.Undercut(SkillLevel) + " за тик");
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int FixedBonusDamage = 15;
            int SkillLevel = trackBar3.Value;
            switch (SkillLevel)
            {
                case 1:
                    FixedBonusDamage = 15;
                    break;
                case 2:
                    FixedBonusDamage = 30;
                    break;
                case 3:
                    FixedBonusDamage = 45;
                    break;
                case 4:
                    FixedBonusDamage = 75;
                    break;
            }
            label3.Text = Convert.ToString(bdskills.SonicWave(SkillLevel, FixedBonusDamage) + "/" + Convert.ToInt32(bdskills.SonicWave(SkillLevel, FixedBonusDamage) / 3));
        }
    }
}
