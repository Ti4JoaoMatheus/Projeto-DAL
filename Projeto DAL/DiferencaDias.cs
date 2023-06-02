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
    public partial class DiferencaDias : Form
    {
        public DiferencaDias()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var data1 = Convert.ToDateTime(mstDataUm.Text);
            var data2 = Convert.ToDateTime(mstDataDois.Text);

            int anos = 0;
            var meses = 0;
            var meses2 = 0;
            var dias = data1.Day - data2.Day;
            int mais = 0;


            if (data1.Year > data2.Year)
            {
                anos = data1.Year - data2.Year;
            }
            if (data1.Year < data2.Year)
            {
                anos = data2.Year - data1.Year;
            }
            if (data1.Month > data2.Month)
            {
                meses = data1.Month - data2.Month;
                meses2 = meses;
            }
            if (data1.Month < data2.Month)
            {
                meses = data2.Month - data1.Month;
                meses2 = meses;
            }


            if (anos > 0)
            {
                while(anos >= 1)
                {
                    meses += 12;
                    anos--;
                }
            }
            if(meses2 > 12)
            {
                while(meses2 >= 12)
                {
                    mais++;
                    meses2 -= 1;
                }
            }
            if(meses > 0)
            {                
                while(meses >= 1)
                {
                    dias += 30;
                    meses -= 1;
                }
            }
            txtResult.Text = $"Diferenca de dias {dias}";
        }
    }
}
