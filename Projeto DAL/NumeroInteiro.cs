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
    public partial class NumeroInteiro : Form
    {
        public NumeroInteiro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            var numero = Convert.ToInt32(mskNumero.Text);
            if (numero % 3 == 0)
            {
                txtResult.Text = "O NUMERO É DIVIDIDO POR 3.";
            }
            else
            {
                txtResult.Text = "O NUMERO NÃO É DIVIDIDO POR 3.";
            }
        }
    }
}
