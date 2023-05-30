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
    public partial class NumerosPares : Form
    {
        public NumerosPares()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NumerosPare_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var primeiro = Convert.ToInt32(mktP.Text);
            var segundo = Convert.ToInt32(mktS.Text);
            //string v = new string;
            //var pares = v;
            var pares = string.Empty;

            while (primeiro < segundo)
            {
                if (primeiro % 2 == 0) 
                {
                    pares = string.Concat(pares + primeiro);
                    if(primeiro + 2 != segundo)
                    {
                        pares = string.Concat(pares + " , ");
                    }
                    if (primeiro + 2 == segundo)
                    {
                        pares = string.Concat(pares + ". ");
                    }
                };                
                primeiro++;

            }
            txtNumerosPares.Text = pares;
        }
    }
}
