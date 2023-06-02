namespace Projeto_DAL
{
    partial class DiferencaDias
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
            label2 = new Label();
            mstDataUm = new MaskedTextBox();
            mstDataDois = new MaskedTextBox();
            btnVerificar = new Button();
            txtResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(108, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(605, 399);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(285, 92);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 1;
            label1.Text = "Primeira Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(285, 141);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 2;
            label2.Text = "Segunda Data";
            // 
            // mstDataUm
            // 
            mstDataUm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mstDataUm.Location = new Point(396, 85);
            mstDataUm.Mask = "00/00/0000";
            mstDataUm.Name = "mstDataUm";
            mstDataUm.Size = new Size(100, 27);
            mstDataUm.TabIndex = 3;
            // 
            // mstDataDois
            // 
            mstDataDois.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mstDataDois.Location = new Point(396, 134);
            mstDataDois.Mask = "00/00/0000";
            mstDataDois.Name = "mstDataDois";
            mstDataDois.Size = new Size(100, 27);
            mstDataDois.TabIndex = 4;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerificar.Location = new Point(337, 203);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(118, 49);
            btnVerificar.TabIndex = 5;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Location = new Point(312, 286);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(160, 97);
            txtResult.TabIndex = 6;
            // 
            // DiferencaDias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(btnVerificar);
            Controls.Add(mstDataDois);
            Controls.Add(mstDataUm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "DiferencaDias";
            Text = "DiferencaDias";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private MaskedTextBox mstDataUm;
        private MaskedTextBox mstDataDois;
        private Button btnVerificar;
        private TextBox txtResult;
    }
}