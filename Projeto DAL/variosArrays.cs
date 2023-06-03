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
    public partial class variosArrays : Form
    {
        int[] numeroUm = new int[] { };
        string numeroUmLista = string.Empty;
        int[] numeroDois = new int[] { };
        string numeroDoisLista = string.Empty;
        string iguais = string.Empty;

        public variosArrays()
        {
            InitializeComponent();
        }

        private void btnListaUm_Click(object sender, EventArgs e)
        {
            if (txtUm.Text != string.Empty)
            {
                var n = Convert.ToInt32(txtUm.Text);
                Array.Resize(ref numeroUm, numeroUm.Length + 1);
                numeroUm[numeroUm.Length - 1] = n;

                if (numeroUmLista == string.Empty)
                {
                    numeroUmLista = string.Concat(numeroUmLista + txtUm.Text);
                }
                else
                {
                    numeroUmLista = string.Concat(numeroUmLista + " , " + txtUm.Text);
                }

                txtUm.Text = string.Empty;
                txtListaUm.Text = numeroUmLista;
            }
            else
            {
                MessageBox.Show("Inserir um numero valido");
            }

        }

        private void btnListaDois_Click(object sender, EventArgs e)
        {
            if (txtDois.Text != string.Empty)
            {
                var n = Convert.ToInt32(txtDois.Text);
                Array.Resize(ref numeroDois, numeroDois.Length + 1);
                numeroDois[numeroDois.Length - 1] = n;

                if (numeroDoisLista == string.Empty)
                {
                    numeroDoisLista = string.Concat(numeroDoisLista + txtDois.Text);
                }
                else
                {
                    numeroDoisLista = string.Concat(numeroDoisLista + " , " + txtDois.Text);
                }

                txtDois.Text = string.Empty;
                txtListaDois.Text = numeroDoisLista;
            }
            else
            {
                MessageBox.Show("Inserir um numero valido");
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if(numeroUm.Length > 0 && numeroDois.Length > 0)
            {

                for (int p = 0; p < numeroUm.Length; p++)
                {
                    if (numeroDois.Contains(numeroUm[p]))
                    {
                        if (iguais == string.Empty)
                        {
                            iguais = string.Concat(iguais + numeroUm[p]);
                        }
                        else
                        {
                            iguais = string.Concat(iguais + " , " + numeroUm[p]);
                        }
                    }
                }
                if(iguais == string.Empty)
                {
                    MessageBox.Show("Não existe numeros iguais.");
                }
                txtResultado.Text = iguais;
            }
            
            else
            {
                MessageBox.Show("As 2 listas tem que possuir numeros.");
            }
        }
    }
}
