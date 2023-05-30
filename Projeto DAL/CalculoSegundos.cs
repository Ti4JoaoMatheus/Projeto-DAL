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
    public partial class CalculoSegundos : Form
    {
        public CalculoSegundos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSegundos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var seg = Convert.ToInt32(mktSeg.Text);
            var horas = 0;
            var minutos = 0;

            if (seg >= 3600)
            {
                while (seg >= 3600)
                {
                    horas++;
                    seg -= 3600;
                }
            }
            if (seg >= 60)
            {
                while (seg >= 60)
                {
                    minutos++;
                    seg -= 60;
                }
            }

            txtHorasSaida.Text = Convert.ToString(horas);
            txtMinutosSaida.Text = Convert.ToString(minutos);
            txtSegundosSaida.Text = Convert.ToString(seg);

        }

        private void CalculoSegundos_Load(object sender, EventArgs e)
        {

        }
    }
}
