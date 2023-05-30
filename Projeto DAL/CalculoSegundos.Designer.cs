namespace Projeto_DAL
{
    partial class CalculoSegundos
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
            dataGridView2 = new DataGridView();
            lbl = new Label();
            btnConverter = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHorasSaida = new TextBox();
            txtMinutosSaida = new TextBox();
            txtSegundosSaida = new TextBox();
            mktSeg = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(136, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(435, 166);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(90, 219);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(520, 118);
            dataGridView2.TabIndex = 2;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(241, 78);
            lbl.Name = "lbl";
            lbl.Size = new Size(77, 20);
            lbl.TabIndex = 3;
            lbl.Text = "Segundos:";
            lbl.Click += label1_Click;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(313, 122);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(96, 59);
            btnConverter.TabIndex = 4;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(204, 251);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 6;
            label1.Text = "Horas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(324, 251);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 7;
            label2.Text = "Minutos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(444, 251);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 8;
            label3.Text = "Segundos";
            label3.Click += label3_Click;
            // 
            // txtHorasSaida
            // 
            txtHorasSaida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtHorasSaida.Location = new Point(182, 291);
            txtHorasSaida.Name = "txtHorasSaida";
            txtHorasSaida.ReadOnly = true;
            txtHorasSaida.Size = new Size(97, 25);
            txtHorasSaida.TabIndex = 9;
            txtHorasSaida.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMinutosSaida
            // 
            txtMinutosSaida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtMinutosSaida.Location = new Point(309, 291);
            txtMinutosSaida.Name = "txtMinutosSaida";
            txtMinutosSaida.ReadOnly = true;
            txtMinutosSaida.Size = new Size(100, 25);
            txtMinutosSaida.TabIndex = 10;
            txtMinutosSaida.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSegundosSaida
            // 
            txtSegundosSaida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSegundosSaida.Location = new Point(433, 291);
            txtSegundosSaida.Name = "txtSegundosSaida";
            txtSegundosSaida.ReadOnly = true;
            txtSegundosSaida.Size = new Size(100, 25);
            txtSegundosSaida.TabIndex = 11;
            txtSegundosSaida.TextAlign = HorizontalAlignment.Center;
            // 
            // mktSeg
            // 
            mktSeg.Location = new Point(324, 75);
            mktSeg.Mask = "000000000000000";
            mktSeg.Name = "mktSeg";
            mktSeg.Size = new Size(147, 23);
            mktSeg.TabIndex = 12;
            // 
            // CalculoSegundos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 349);
            Controls.Add(mktSeg);
            Controls.Add(txtSegundosSaida);
            Controls.Add(txtMinutosSaida);
            Controls.Add(txtHorasSaida);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConverter);
            Controls.Add(lbl);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "CalculoSegundos";
            Text = "CalculoSegundos";
            Load += CalculoSegundos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label lbl;
        private Button btnConverter;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHorasSaida;
        private TextBox txtMinutosSaida;
        private TextBox txtSegundosSaida;
        private MaskedTextBox mktSeg;
    }
}