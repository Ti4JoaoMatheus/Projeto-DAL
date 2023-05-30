namespace Projeto_DAL
{
    partial class NumeroInteiro
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            mskNumero = new MaskedTextBox();
            btnDivide = new Button();
            label2 = new Label();
            txtResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 113);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(142, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(530, 350);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // mskNumero
            // 
            mskNumero.Location = new Point(420, 151);
            mskNumero.Mask = "00000000";
            mskNumero.Name = "mskNumero";
            mskNumero.Size = new Size(100, 23);
            mskNumero.TabIndex = 2;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(354, 221);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(103, 40);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "Verificar";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(289, 151);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 4;
            label2.Text = "Numero inteiro :";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(289, 317);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(231, 23);
            txtResult.TabIndex = 5;
            // 
            // NumeroInteiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(label2);
            Controls.Add(btnDivide);
            Controls.Add(mskNumero);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "NumeroInteiro";
            Text = "NumeroInteiro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private MaskedTextBox mskNumero;
        private Button btnDivide;
        private Label label2;
        private TextBox txtResult;
    }
}