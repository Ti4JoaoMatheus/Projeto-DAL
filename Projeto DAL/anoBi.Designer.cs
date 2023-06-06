namespace Projeto_DAL
{
    partial class anoBi
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
            mstAno = new MaskedTextBox();
            btnVerificar = new Button();
            txtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(93, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(608, 371);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 131);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 1;
            label1.Text = "Ano : ";
            // 
            // mstAno
            // 
            mstAno.Location = new Point(386, 129);
            mstAno.Mask = "00/00/0000";
            mstAno.Name = "mstAno";
            mstAno.Size = new Size(100, 23);
            mstAno.TabIndex = 2;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerificar.Location = new Point(352, 184);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 45);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += button1_Click;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.Location = new Point(299, 295);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(199, 27);
            txtResultado.TabIndex = 4;
            // 
            // anoBi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(btnVerificar);
            Controls.Add(mstAno);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "anoBi";
            Text = "anoBi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private MaskedTextBox mstAno;
        private Button btnVerificar;
        private TextBox txtResultado;
    }
}