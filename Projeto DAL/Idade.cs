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
    public partial class Idade : Form
    {
        public Idade()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(mtbNasc.Text != "  /  /")
            {
                var data = Convert.ToDateTime(mtbNasc.Text);
                var atual = DateTime.UtcNow;
                if (data < DateTime.Now)
                {
                    int result = IdadeCal(data);
                    txtIdade.Text = $"A idade é {result} Anos";
                }
                else
                {
                    MessageBox.Show("Não é uma data valida.");
                }
            }
            else
            {
                MessageBox.Show("Não é uma data valida.");
            }
            
        }

        private static int IdadeCal (DateTime dt)
        {
            int idade = DateTime.Now.Year - dt.Year;
            if(DateTime.Now.DayOfYear < dt.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }
    }
}
