namespace Projeto_DAL
{
    partial class deZeroACem
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
            txtAdicionados = new TextBox();
            btnAdc = new Button();
            btnVerificar = new Button();
            mstNumero = new MaskedTextBox();
            label1 = new Label();
            txtFinal = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(730, 441);
            dataGridView1.TabIndex = 0;
            // 
            // txtAdicionados
            // 
            txtAdicionados.Location = new Point(63, 283);
            txtAdicionados.Multiline = true;
            txtAdicionados.Name = "txtAdicionados";
            txtAdicionados.ReadOnly = true;
            txtAdicionados.Size = new Size(276, 155);
            txtAdicionados.TabIndex = 1;
            // 
            // btnAdc
            // 
            btnAdc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdc.Location = new Point(280, 207);
            btnAdc.Name = "btnAdc";
            btnAdc.Size = new Size(75, 23);
            btnAdc.TabIndex = 2;
            btnAdc.Text = "Adicionar";
            btnAdc.UseVisualStyleBackColor = true;
            btnAdc.Click += btnAdc_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerificar.Location = new Point(428, 207);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // mstNumero
            // 
            mstNumero.Location = new Point(403, 130);
            mstNumero.Name = "mstNumero";
            mstNumero.Size = new Size(100, 23);
            mstNumero.TabIndex = 4;
            mstNumero.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 133);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 5;
            label1.Text = "Inserir numero:";
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(428, 283);
            txtFinal.Multiline = true;
            txtFinal.Name = "txtFinal";
            txtFinal.ReadOnly = true;
            txtFinal.Size = new Size(276, 155);
            txtFinal.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 257);
            label2.Name = "label2";
            label2.Size = new Size(144, 17);
            label2.TabIndex = 7;
            label2.Text = "Numeros Adicionados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(428, 257);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 8;
            label3.Text = "Resultado";
            // 
            // deZeroACem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFinal);
            Controls.Add(label1);
            Controls.Add(mstNumero);
            Controls.Add(btnVerificar);
            Controls.Add(btnAdc);
            Controls.Add(txtAdicionados);
            Controls.Add(dataGridView1);
            Name = "deZeroACem";
            Text = "deZeroACem";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtAdicionados;
        private Button btnAdc;
        private Button btnVerificar;
        private MaskedTextBox mstNumero;
        private Label label1;
        private TextBox txtFinal;
        private Label label2;
        private Label label3;
    }
}