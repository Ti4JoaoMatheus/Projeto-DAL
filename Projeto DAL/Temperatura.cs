using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DAL
{
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var cel = Convert.ToInt32(mktTemp.Text);
            var result = " ";
            if (rbFahrenheit.Checked)
            {
                result = Convert.ToString((cel * 1.8) + 32);
            }
            if (rbKelvin.Checked)
            {
                result = Convert.ToString(cel + 273.15);
            }

            txtResult.Text = result;
        }
    }
}
