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
    public partial class mmc : Form
    {
        public mmc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAltura.Text != "" && txtPeso.Text != "")
            {
                var peso = Convert.ToDouble(txtPeso.Text);
                var altura = Convert.ToDouble(txtAltura.Text);
                var indice = "";
                var ob = "";
                var imc = peso / (altura * altura);

                txtResult.Text = "Seu IMC é " + imc.ToString("F");

                if (imc < 18.5)
                {
                    indice = "MAGREZA";
                    ob = "0";
                }
                if (imc > 18.5 && imc < 24.9)
                {
                    indice = "NORMAL";
                    ob = "0";
                }
                if (imc > 25.0 && imc < 29.9)
                {
                    indice = "SOBREPESO";
                    ob = "1";
                }
                if (imc > 30.0 && imc < 39.9)
                {
                    indice = "OBESIDADE";
                    ob = "2";
                }
                if (imc > 40.0)
                {
                    indice = "OBESIDADE GRAVE";
                    ob = "3";
                }
                txtindice.Text = indice;
                txtgrau.Text = ob;
            }
            else
            {
                MessageBox.Show("Inserir o peso e altura.");
            }
        }
    }
}
