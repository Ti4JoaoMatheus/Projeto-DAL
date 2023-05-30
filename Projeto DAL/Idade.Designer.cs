namespace Projeto_DAL
{
    partial class Idade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            mtbNasc = new MaskedTextBox();
            label1 = new Label();
            txtIdade = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(105, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(605, 363);
            dataGridView1.TabIndex = 0;
            // 
            // mtbNasc
            // 
            mtbNasc.Location = new Point(416, 120);
            mtbNasc.Mask = "00/00/0000";
            mtbNasc.Name = "mtbNasc";
            mtbNasc.Size = new Size(142, 23);
            mtbNasc.TabIndex = 1;
            mtbNasc.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(259, 123);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 2;
            label1.Text = "Data de Nascimento";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(391, 308);
            txtIdade.Name = "txtIdade";
            txtIdade.ReadOnly = true;
            txtIdade.Size = new Size(106, 23);
            txtIdade.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(322, 311);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 4;
            label2.Text = "Idade";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(356, 191);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(104, 47);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Idade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(txtIdade);
            Controls.Add(label1);
            Controls.Add(mtbNasc);
            Controls.Add(dataGridView1);
            Name = "Idade";
            Text = "Idade";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MaskedTextBox mtbNasc;
        private Label label1;
        private TextBox txtIdade;
        private Label label2;
        private Button btnCalcular;
    }
}