namespace Projeto_DAL
{
    partial class Temperatura
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
            rbFahrenheit = new RadioButton();
            rbKelvin = new RadioButton();
            btnConverter = new Button();
            label1 = new Label();
            mktTemp = new MaskedTextBox();
            txtResult = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(81, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(621, 350);
            dataGridView1.TabIndex = 0;
            // 
            // rbFahrenheit
            // 
            rbFahrenheit.AutoSize = true;
            rbFahrenheit.Location = new Point(232, 171);
            rbFahrenheit.Name = "rbFahrenheit";
            rbFahrenheit.Size = new Size(81, 19);
            rbFahrenheit.TabIndex = 1;
            rbFahrenheit.TabStop = true;
            rbFahrenheit.Text = "Fahrenheit";
            rbFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rbKelvin
            // 
            rbKelvin.AutoSize = true;
            rbKelvin.Location = new Point(319, 171);
            rbKelvin.Name = "rbKelvin";
            rbKelvin.Size = new Size(57, 19);
            rbKelvin.TabIndex = 2;
            rbKelvin.TabStop = true;
            rbKelvin.Text = "Kelvin";
            rbKelvin.UseVisualStyleBackColor = true;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(411, 147);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(94, 66);
            btnConverter.TabIndex = 4;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(232, 92);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 5;
            label1.Text = "Temperatura : ";
            // 
            // mktTemp
            // 
            mktTemp.Location = new Point(349, 93);
            mktTemp.Mask = "0000";
            mktTemp.Name = "mktTemp";
            mktTemp.Size = new Size(156, 23);
            mktTemp.TabIndex = 6;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Location = new Point(349, 279);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(100, 25);
            txtResult.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(264, 279);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 8;
            label2.Text = "Resultado";
            // 
            // Temperatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtResult);
            Controls.Add(mktTemp);
            Controls.Add(label1);
            Controls.Add(btnConverter);
            Controls.Add(rbKelvin);
            Controls.Add(rbFahrenheit);
            Controls.Add(dataGridView1);
            Name = "Temperatura";
            Text = "Temperatura";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private RadioButton rbFahrenheit;
        private RadioButton rbKelvin;
        private Button btnConverter;
        private Label label1;
        private MaskedTextBox mktTemp;
        private TextBox txtResult;
        private Label label2;
    }
}