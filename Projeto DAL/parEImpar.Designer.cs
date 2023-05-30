namespace Projeto_DAL
{
    partial class parEImpar
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
            btnConverter = new Button();
            lblNome = new Label();
            txtResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(146, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(509, 334);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(279, 121);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 1;
            label1.Text = "Numero Inteiro :";
            // 
            // mtbNumero
            // 
            mtbNumero.Location = new Point(411, 121);
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(100, 23);
            mtbNumero.TabIndex = 2;
            // 
            // btnConverter
            // 
            btnConverter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConverter.Location = new Point(348, 168);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(116, 42);
            btnConverter.TabIndex = 3;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(303, 303);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 15);
            lblNome.TabIndex = 4;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(255, 277);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(277, 23);
            txtResult.TabIndex = 5;
            // 
            // parEImpar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(lblNome);
            Controls.Add(btnConverter);
            Controls.Add(mtbNumero);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "parEImpar";
            Text = "parEImpar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private MaskedTextBox mtbNumero;
        private Button btnConverter;
        private Label lblNome;
        private TextBox txtResult;
    }
}