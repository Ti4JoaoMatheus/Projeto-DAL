namespace Projeto_DAL
{
    partial class maiorPeloMenor
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
            label1 = new Label();
            mtbUm = new MaskedTextBox();
            mtbDois = new MaskedTextBox();
            btnVerificar = new Button();
            label2 = new Label();
            txtResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(116, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(608, 386);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(310, 104);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "Numero 1 :";
            // 
            // mtbUm
            // 
            mtbUm.Location = new Point(451, 105);
            mtbUm.Mask = "00000";
            mtbUm.Name = "mtbUm";
            mtbUm.Size = new Size(100, 23);
            mtbUm.TabIndex = 2;
            // 
            // mtbDois
            // 
            mtbDois.Location = new Point(451, 177);
            mtbDois.Mask = "00000";
            mtbDois.Name = "mtbDois";
            mtbDois.Size = new Size(100, 23);
            mtbDois.TabIndex = 3;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerificar.Location = new Point(390, 243);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(102, 41);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(310, 180);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 5;
            label2.Text = "Numero 2 :";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(272, 327);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(323, 80);
            txtResult.TabIndex = 6;
            // 
            // maiorPeloMenor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(label2);
            Controls.Add(btnVerificar);
            Controls.Add(mtbDois);
            Controls.Add(mtbUm);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "maiorPeloMenor";
            Text = "maiorPeloMenor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private MaskedTextBox mtbUm;
        private MaskedTextBox mtbDois;
        private Button btnVerificar;
        private Label label2;
        private TextBox txtResult;
    }
}