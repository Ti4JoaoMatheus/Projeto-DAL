namespace Projeto_DAL
{
    partial class variosArrays
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
            txtUm = new TextBox();
            txtDois = new TextBox();
            txtListaUm = new TextBox();
            txtListaDois = new TextBox();
            btnListaUm = new Button();
            btnVerificar = new Button();
            btnListaDois = new Button();
            txtResultado = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-35, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(840, 410);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 84);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 1;
            label1.Text = "Lista 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(301, 84);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 2;
            label2.Text = "Lista 2";
            // 
            // txtUm
            // 
            txtUm.Location = new Point(67, 78);
            txtUm.Name = "txtUm";
            txtUm.Size = new Size(100, 23);
            txtUm.TabIndex = 3;
            // 
            // txtDois
            // 
            txtDois.Location = new Point(355, 78);
            txtDois.Name = "txtDois";
            txtDois.Size = new Size(100, 23);
            txtDois.TabIndex = 4;
            // 
            // txtListaUm
            // 
            txtListaUm.Location = new Point(12, 213);
            txtListaUm.Multiline = true;
            txtListaUm.Name = "txtListaUm";
            txtListaUm.ReadOnly = true;
            txtListaUm.Size = new Size(237, 195);
            txtListaUm.TabIndex = 5;
            // 
            // txtListaDois
            // 
            txtListaDois.Location = new Point(301, 213);
            txtListaDois.Multiline = true;
            txtListaDois.Name = "txtListaDois";
            txtListaDois.ReadOnly = true;
            txtListaDois.Size = new Size(238, 195);
            txtListaDois.TabIndex = 6;
            // 
            // btnListaUm
            // 
            btnListaUm.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnListaUm.Location = new Point(92, 126);
            btnListaUm.Name = "btnListaUm";
            btnListaUm.Size = new Size(75, 53);
            btnListaUm.TabIndex = 7;
            btnListaUm.Text = "Adicionar Lista 1";
            btnListaUm.UseVisualStyleBackColor = true;
            btnListaUm.Click += btnListaUm_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerificar.Location = new Point(637, 126);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(67, 23);
            btnVerificar.TabIndex = 8;
            btnVerificar.Text = "Verificar";
            btnVerificar.TextAlign = ContentAlignment.MiddleLeft;
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnListaDois
            // 
            btnListaDois.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnListaDois.Location = new Point(380, 126);
            btnListaDois.Name = "btnListaDois";
            btnListaDois.Size = new Size(75, 53);
            btnListaDois.TabIndex = 9;
            btnListaDois.Text = "Adicionar Lista 2";
            btnListaDois.UseVisualStyleBackColor = true;
            btnListaDois.Click += btnListaDois_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(570, 213);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(218, 195);
            txtResultado.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 199);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 11;
            label3.Text = "Lista 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 199);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 12;
            label4.Text = "Lista 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(570, 199);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 13;
            label5.Text = "Resultado";
            // 
            // variosArrays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(btnListaDois);
            Controls.Add(btnVerificar);
            Controls.Add(btnListaUm);
            Controls.Add(txtListaDois);
            Controls.Add(txtListaUm);
            Controls.Add(txtDois);
            Controls.Add(txtUm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "variosArrays";
            Text = "variosArrays";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtUm;
        private TextBox txtDois;
        private TextBox txtListaUm;
        private TextBox txtListaDois;
        private Button btnListaUm;
        private Button btnVerificar;
        private Button btnListaDois;
        private TextBox txtResultado;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}