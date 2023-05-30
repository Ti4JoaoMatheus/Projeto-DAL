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
    public partial class Home : Form
    {
        private int childFormNumber = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void segundosCalculadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var calculoSegundos = new CalculoSegundos();
            calculoSegundos.MdiParent = this;
            calculoSegundos.Show();
        }

        private void numerosParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var numerosPares = new NumerosPares();
            numerosPares.MdiParent = this;
            numerosPares.Show();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temperatura = new Temperatura();
            temperatura.MdiParent = this;
            temperatura.Show();
        }

        private void dividePor3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var divide = new NumeroInteiro();
            divide.MdiParent = this;
            divide.Show();
        }

        private void idadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var idade = new Idade();
            idade.MdiParent = this;
            idade.Show();
        }

        private void parEImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pareimpar = new parEImpar();
            pareimpar.MdiParent = this;
            pareimpar.Show();
        }
    }
}
