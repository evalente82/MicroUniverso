namespace TesteMicroUniverso.Forms
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoAprovaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canfiguraçãoFaixasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.históricoAprovaçãoToolStripMenuItem,
            this.canfiguraçãoFaixasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1296, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // históricoAprovaçãoToolStripMenuItem
            // 
            this.históricoAprovaçãoToolStripMenuItem.Name = "históricoAprovaçãoToolStripMenuItem";
            this.históricoAprovaçãoToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.históricoAprovaçãoToolStripMenuItem.Text = "Histórico Aprovação";
            this.históricoAprovaçãoToolStripMenuItem.Click += new System.EventHandler(this.históricoAprovaçãoToolStripMenuItem_Click);
            // 
            // canfiguraçãoFaixasToolStripMenuItem
            // 
            this.canfiguraçãoFaixasToolStripMenuItem.Name = "canfiguraçãoFaixasToolStripMenuItem";
            this.canfiguraçãoFaixasToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.canfiguraçãoFaixasToolStripMenuItem.Text = "Canfiguração Faixas";
            this.canfiguraçãoFaixasToolStripMenuItem.Click += new System.EventHandler(this.canfiguraçãoFaixasToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 498);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoAprovaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canfiguraçãoFaixasToolStripMenuItem;
    }
}