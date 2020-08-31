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
    public partial class SelectForm : Form
    {
        InputForm inputform;
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectChamp(object sender, EventArgs e)
        {
            Stats.IconName = (sender as PictureBox).Name;
            inputform = new InputForm();
            inputform.Show();
        }
    }
}
