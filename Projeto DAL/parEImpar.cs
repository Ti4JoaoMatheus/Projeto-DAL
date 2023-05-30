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
    public partial class parEImpar : Form
    {
        public parEImpar()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (mtbNumero.Text != " ")
            {
                var numero = Convert.ToDouble(mtbNumero.Text);
                if (numero % 2 == 0)
                {
                    txtResult.Text = Convert.ToString($"Numero inserido é par e seu dobro é {numero * 2}.");
                }
                else
                {
                    txtResult.Text = Convert.ToString($"Numero inserido é impar e sua metate é {numero / 2}.");
                }
            }
            else
            {
                MessageBox.Show("inserir um numero valido");
            }
        }
    }
}
