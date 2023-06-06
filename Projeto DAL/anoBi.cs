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
    public partial class anoBi : Form
    {
        public anoBi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var o = Convert.ToDateTime(mstAno.Text);

            var ano = o.Year;

            if (ano % 4 == 0)
            {
                txtResultado.Text = "É um ano bissexto";
            }
            else
            {
                txtResultado.Text = "Não é um ano bissexto";
            }
        }
    }
}
