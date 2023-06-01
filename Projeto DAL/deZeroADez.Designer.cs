namespace Projeto_DAL
{
    partial class deZeroADez
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
            mtbNumero = new MaskedTextBox();
            btnvalidar = new Button();
            txtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(80, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(636, 392);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(274, 124);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 1;
            label1.Text = "Inserir Numero : ";
            // 
            // mtbNumero
            // 
            mtbNumero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtbNumero.Location = new Point(413, 121);
            mtbNumero.Mask = "00";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(100, 27);
            mtbNumero.TabIndex = 2;
            // 
            // btnvalidar
            // 
            btnvalidar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnvalidar.Location = new Point(344, 188);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(103, 43);
            btnvalidar.TabIndex = 3;
            btnvalidar.Text = "Validar";
            btnvalidar.UseVisualStyleBackColor = true;
            btnvalidar.Click += btnvalidar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.Location = new Point(274, 281);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(239, 95);
            txtResultado.TabIndex = 4;
            // 
            // deZeroADez
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(btnvalidar);
            Controls.Add(mtbNumero);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "deZeroADez";
            Text = "deZeroADez";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private MaskedTextBox mtbNumero;
        private Button btnvalidar;
        private TextBox txtResultado;
    }
}