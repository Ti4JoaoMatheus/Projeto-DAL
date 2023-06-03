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
    public partial class deZeroACem : Form
    {
        int[] numeros = new int[] { };
        string nAd = string.Empty;
        int zeroV = 0;
        int cinCin = 0;
        int cusc = 0;
        int sscem = 0;

        public deZeroACem()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        private void btnAdc_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(mstNumero.Text);
            Array.Resize(ref numeros, numeros.Length + 1);
            numeros[numeros.Length - 1] = n;

            if (nAd == string.Empty)
            {
                nAd = string.Concat(nAd + mstNumero.Text);
            }
            else
            {
                nAd = string.Concat(nAd + " , " + mstNumero.Text);
            }

            mstNumero.Text = string.Empty;
            txtAdicionados.Text = nAd;

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //if(numeros.Length >= 1)
            //{
            //    while(numeros.Length > 0)
            //    {
            //        numeros.
            //    }
            //}


            for (int p = 0; p < numeros.Length; p++)
            {
                if (numeros[p] > 0 && numeros[p] <= 25)
                {
                    zeroV++;
                }
                if (numeros[p] >= 26 && numeros[p] <= 50)
                {
                    cinCin++;
                }
                if (numeros[p] >= 51 && numeros[p] <= 75)
                {
                    cusc++;
                }
                if (numeros[p] >= 76 && numeros[p] <= 100)
                {
                    sscem++;
                }
            }

            txtFinal.Text = $"São {zeroV} numero de 0 a 25, São {cinCin} numeros de 26 a 50, São {cusc} numeros de 51 a 75, São {sscem} numeros de 76 a 100.";
        }
    }
}
