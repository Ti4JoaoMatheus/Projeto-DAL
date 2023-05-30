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
    public partial class maiorPeloMenor : Form
    {
        public maiorPeloMenor()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if(mtbUm.Text != "" && mtbDois.Text != "")
            {
                var numero1 = Convert.ToInt32(mtbUm.Text);
                var numero2 = Convert.ToInt32(mtbDois.Text);

                if (numero1 > numero2)
                {
                    txtResult.Text = Convert.ToString($"O primeiro numero é o maior e a diferença é : {numero1 - numero2}");
                }
                if (numero1 < numero2)
                {
                    txtResult.Text = Convert.ToString($"O segundo numero é o maior e a diferença é :{numero2 - numero1}");
                }
                if (numero1 == numero2)
                {
                    txtResult.Text = "Os numeros são iguais";
                }
            }
            else
            {
                MessageBox.Show("Inserir o numero1 e o numero2.");
            }
        }
    }
}
