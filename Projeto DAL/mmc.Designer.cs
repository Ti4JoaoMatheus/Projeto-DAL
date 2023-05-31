namespace Projeto_DAL
{
    partial class mmc
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
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtResult = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtindice = new TextBox();
            txtgrau = new TextBox();
            GRAU = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(157, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(527, 409);
            dataGridView1.TabIndex = 0;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(421, 86);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 1;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(421, 136);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(388, 214);
            button1.Name = "button1";
            button1.Size = new Size(100, 43);
            button1.TabIndex = 3;
            button1.Text = "Calcular índice";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(367, 85);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 4;
            label1.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(356, 139);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 5;
            label2.Text = "Altura";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Location = new Point(190, 326);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(196, 50);
            txtResult.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(272, 294);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 7;
            label3.Text = "IMC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(434, 294);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 8;
            label4.Text = "INDICE";
            // 
            // txtindice
            // 
            txtindice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtindice.Location = new Point(412, 326);
            txtindice.Multiline = true;
            txtindice.Name = "txtindice";
            txtindice.ReadOnly = true;
            txtindice.Size = new Size(100, 50);
            txtindice.TabIndex = 9;
            // 
            // txtgrau
            // 
            txtgrau.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtgrau.Location = new Point(541, 326);
            txtgrau.Multiline = true;
            txtgrau.Name = "txtgrau";
            txtgrau.ReadOnly = true;
            txtgrau.Size = new Size(100, 50);
            txtgrau.TabIndex = 10;
            // 
            // GRAU
            // 
            GRAU.AutoSize = true;
            GRAU.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            GRAU.Location = new Point(567, 294);
            GRAU.Name = "GRAU";
            GRAU.Size = new Size(52, 20);
            GRAU.TabIndex = 11;
            GRAU.Text = "GRAU";
            // 
            // mmc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GRAU);
            Controls.Add(txtgrau);
            Controls.Add(txtindice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(dataGridView1);
            Name = "mmc";
            Text = "mmc";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtResult;
        private Label label3;
        private Label label4;
        private TextBox txtindice;
        private TextBox txtgrau;
        private Label GRAU;
    }
}