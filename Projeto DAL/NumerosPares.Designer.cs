namespace Projeto_DAL
{
    partial class NumerosPares
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
            mktP = new MaskedTextBox();
            mktS = new MaskedTextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            txtNumerosPares = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(106, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(509, 203);
            dataGridView1.TabIndex = 0;
            // 
            // mktP
            // 
            mktP.Location = new Point(178, 91);
            mktP.Mask = "000000000000";
            mktP.Name = "mktP";
            mktP.Size = new Size(100, 23);
            mktP.TabIndex = 1;
            // 
            // mktS
            // 
            mktS.Location = new Point(434, 91);
            mktS.Mask = "00000000000";
            mktS.Name = "mktS";
            mktS.Size = new Size(100, 23);
            mktS.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(407, 46);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 4;
            label2.Text = "Segundo Numero";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(301, 146);
            button1.Name = "button1";
            button1.Size = new Size(92, 55);
            button1.TabIndex = 5;
            button1.Text = "Verificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 10;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(46, 251);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(610, 124);
            dataGridView2.TabIndex = 7;
            // 
            // txtNumerosPares
            // 
            txtNumerosPares.Location = new Point(60, 265);
            txtNumerosPares.Multiline = true;
            txtNumerosPares.Name = "txtNumerosPares";
            txtNumerosPares.ReadOnly = true;
            txtNumerosPares.ScrollBars = ScrollBars.Vertical;
            txtNumerosPares.Size = new Size(579, 100);
            txtNumerosPares.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 233);
            label4.Name = "label4";
            label4.Size = new Size(157, 15);
            label4.TabIndex = 9;
            label4.Text = "Numeros Pares Localizados :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(155, 46);
            label5.Name = "label5";
            label5.Size = new Size(143, 21);
            label5.TabIndex = 11;
            label5.Text = "Primeiro Numero";
            // 
            // NumerosPares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 387);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNumerosPares);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(mktS);
            Controls.Add(mktP);
            Controls.Add(dataGridView1);
            Name = "NumerosPares";
            Text = "NumerosPares";
            Load += NumerosPare_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MaskedTextBox mktP;
        private MaskedTextBox mktS;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private DataGridView dataGridView2;
        private TextBox txtNumerosPares;
        private Label label4;
        private Label label5;
    }
}