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
    public partial class vetor : Form
    {
        public vetor()
        {
            InitializeComponent();
        }
        int[] numerosLista = new int[] { };
        string numeroString = string.Empty;
        int count = 0;
        int parametro = 0;



        private void btnMuti_Click(object sender, EventArgs e)
        {
            for (int p = 1; p <= numerosLista.Length; p++)
            {
                if (p == 1)
                {
                    txtResult1.Text = Convert.ToString(p * numerosLista[parametro]);
                    parametro++;
                }
                else if (p == 2)
                {
                    txtResult2.Text = Convert.ToString(p * numerosLista[parametro]);
                    parametro++;
                }
                else if (p == 3)
                {
                    txtResult3.Text = Convert.ToString(p * numerosLista[parametro]);
                    parametro++;
                }
                else if (p == 4)
                {
                    txtResult4.Text = Convert.ToString(p * numerosLista[parametro]);
                    parametro++;
                }
                else if (p == 5)
                {
                    txtResult5.Text = Convert.ToString(p * numerosLista[parametro]);
                    parametro++;
                }
                else if (p == 6)
                {
                    txtResult6.Text = Convert.ToString(p * numerosLista[parametro]);
                    parametro++;
                }
                else if (p == 7)
                {
                    txtResult7.Text = Convert.ToString(p * numerosLista[parametro]);
                    parametro++;
                }
                else if (p == 8)
                {
                    txtResult8.Text = Convert.ToString(p * numerosLista[parametro]);
                    parametro++;
                }

            }
        }

        private void btnAdc_Click(object sender, EventArgs e)
        {


            if (txtNumero.Text != string.Empty)
            {
                if (count < 8)
                {
                    var n = Convert.ToInt32(txtNumero.Text);
                    Array.Resize(ref numerosLista, numerosLista.Length + 1);
                    numerosLista[numerosLista.Length - 1] = n;

                    if (numeroString == string.Empty)
                    {
                        numeroString = string.Concat(numeroString + txtNumero.Text);
                        count++;
                    }
                    else
                    {
                        numeroString = string.Concat(numeroString + " , " + txtNumero.Text);
                        count++;
                    }

                    txtNumero.Text = string.Empty;
                    txtNumerosLista.Text = numeroString;
                }
                else
                {
                    MessageBox.Show("Limite de 8 numeros atingidos");
                }
            }
            else
            {
                MessageBox.Show("Inserir um numero valido");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {


        }
    }
}
