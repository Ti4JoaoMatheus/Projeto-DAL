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
    public partial class deZeroADez : Form
    {
        public deZeroADez()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            if (mtbNumero.Text != "")
            {
                var numero = Convert.ToDouble(mtbNumero.Text);
                if (numero == 10)
                {
                    txtResultado.Text = "Excelente";
                }
                else if (numero == 8 && numero <= 9.9)
                {
                    txtResultado.Text = "Muito Bom";
                }
                else if (numero == 7 && numero <= 7.9)
                {
                    txtResultado.Text = "Bom";
                }
                else if (numero <= 6.9)
                {
                    txtResultado.Text = "Insatisfatorio";
                }

            }
            else
            {
                txtResultado.Text = "Nota inválida";
            }

        }
    }
}
