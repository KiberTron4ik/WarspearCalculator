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
    public partial class InputForm : Form
    {

        public InputForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK);
            }
            else if (float.Parse(textBox3.Text) > 50 || float.Parse(textBox4.Text) > 50 || float.Parse(textBox6.Text) > 50 || float.Parse(textBox9.Text) > 60 || int.Parse(textBox5.Text) > 32 || int.Parse(textBox5.Text) < 1)
            {
                MessageBox.Show("Неверные значения!", "Ошибка!", MessageBoxButtons.OK);
            }
            else
            {
                Character.PhysicalDmg = Convert.ToDouble(textBox1.Text);
                Character.MagicalDmg = Convert.ToDouble(textBox2.Text);
                Character.Ferocity = Convert.ToDouble(textBox3.Text) / 100;
                Character.Penetration = Convert.ToDouble(textBox4.Text) / 100;
                Character.Level = Convert.ToDouble(textBox5.Text);
                Character.PowerAuto = Convert.ToDouble(textBox6.Text) / 100;
                Character.PhysicalDef = Convert.ToDouble(textBox7.Text) / (float.Parse(textBox7.Text) + 6500);
                Character.MagicalDef = Convert.ToDouble(textBox8.Text) / (float.Parse(textBox8.Text) + 6500);
                Character.Sustain = Convert.ToDouble(textBox9.Text) / 100;

                    switch (Character.IconName)
                {
                    
                    case "BarbarianIcon":
                        BarbarianForm barbarForm = new BarbarianForm();
                        barbarForm.ShowDialog();
                        break;
                    case "ShamanIcon":
                        ShamanForm shamanForm = new ShamanForm();
                        shamanForm.ShowDialog();
                        break;
                    case "BdIcon":
                        BladeDancerForm bdForm = new BladeDancerForm();
                        bdForm.ShowDialog();
                        break;
                    case "HunterIcon":
                        break;

                }
            }
        }

        private void InputInt(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void InputFloat(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}
