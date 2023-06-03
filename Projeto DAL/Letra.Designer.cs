namespace Projeto_DAL
{
    partial class Letra
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
            btnProcurar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtFrase = new TextBox();
            txtLetra = new TextBox();
            txtrResultado = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(90, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(628, 414);
            dataGridView1.TabIndex = 0;
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new Point(371, 274);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(75, 33);
            btnProcurar.TabIndex = 1;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(388, 91);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 2;
            label1.Text = "Frase";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(388, 198);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 3;
            label2.Text = "Letra";
            // 
            // txtFrase
            // 
            txtFrase.Location = new Point(157, 123);
            txtFrase.Multiline = true;
            txtFrase.Name = "txtFrase";
            txtFrase.Size = new Size(509, 59);
            txtFrase.TabIndex = 4;
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(358, 229);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(100, 23);
            txtLetra.TabIndex = 5;
            // 
            // txtrResultado
            // 
            txtrResultado.Location = new Point(358, 371);
            txtrResultado.Name = "txtrResultado";
            txtrResultado.Size = new Size(100, 23);
            txtrResultado.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 340);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 7;
            label3.Text = "Ocorrencias";
            // 
            // Letra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtrResultado);
            Controls.Add(txtLetra);
            Controls.Add(txtFrase);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnProcurar);
            Controls.Add(dataGridView1);
            Name = "Letra";
            Text = "Letra";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnProcurar;
        private Label label1;
        private Label label2;
        private TextBox txtFrase;
        private TextBox txtLetra;
        private TextBox txtrResultado;
        private Label label3;
    }
}