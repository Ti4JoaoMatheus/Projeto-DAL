namespace Projeto_DAL
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip = new ToolTip(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            contadoresToolStripMenuItem = new ToolStripMenuItem();
            segundosCalculadosToolStripMenuItem = new ToolStripMenuItem();
            numerosParesToolStripMenuItem = new ToolStripMenuItem();
            temperaturaToolStripMenuItem = new ToolStripMenuItem();
            dividePor3ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { contadoresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(737, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // contadoresToolStripMenuItem
            // 
            contadoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { segundosCalculadosToolStripMenuItem, numerosParesToolStripMenuItem, temperaturaToolStripMenuItem, dividePor3ToolStripMenuItem });
            contadoresToolStripMenuItem.Name = "contadoresToolStripMenuItem";
            contadoresToolStripMenuItem.Size = new Size(80, 20);
            contadoresToolStripMenuItem.Text = "Contadores";
            // 
            // segundosCalculadosToolStripMenuItem
            // 
            segundosCalculadosToolStripMenuItem.Name = "segundosCalculadosToolStripMenuItem";
            segundosCalculadosToolStripMenuItem.Size = new Size(185, 22);
            segundosCalculadosToolStripMenuItem.Text = "Segundos calculados";
            segundosCalculadosToolStripMenuItem.Click += segundosCalculadosToolStripMenuItem_Click;
            // 
            // numerosParesToolStripMenuItem
            // 
            numerosParesToolStripMenuItem.Name = "numerosParesToolStripMenuItem";
            numerosParesToolStripMenuItem.Size = new Size(185, 22);
            numerosParesToolStripMenuItem.Text = "Numeros Pares";
            numerosParesToolStripMenuItem.Click += numerosParesToolStripMenuItem_Click;
            // 
            // temperaturaToolStripMenuItem
            // 
            temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            temperaturaToolStripMenuItem.Size = new Size(185, 22);
            temperaturaToolStripMenuItem.Text = "Temperatura";
            temperaturaToolStripMenuItem.Click += temperaturaToolStripMenuItem_Click;
            // 
            // dividePor3ToolStripMenuItem
            // 
            dividePor3ToolStripMenuItem.Name = "dividePor3ToolStripMenuItem";
            dividePor3ToolStripMenuItem.Size = new Size(185, 22);
            dividePor3ToolStripMenuItem.Text = "Divide por 3";
            dividePor3ToolStripMenuItem.Click += dividePor3ToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Home";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem contadoresToolStripMenuItem;
        private ToolStripMenuItem segundosCalculadosToolStripMenuItem;
        private ToolStripMenuItem numerosParesToolStripMenuItem;
        private ToolStripMenuItem temperaturaToolStripMenuItem;
        private ToolStripMenuItem dividePor3ToolStripMenuItem;
    }
}



