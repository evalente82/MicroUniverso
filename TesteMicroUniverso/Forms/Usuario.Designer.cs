namespace TesteMicroUniverso.Forms
{
    partial class Usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtValorMinAprov = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtValorMaxAprov = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboPapel = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGravar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Novo Usuário";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(869, 276);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(42, 24);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(160, 20);
            this.TxtLogin.TabIndex = 3;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(208, 24);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(122, 20);
            this.TxtSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Papel";
            // 
            // TxtValorMinAprov
            // 
            this.TxtValorMinAprov.Location = new System.Drawing.Point(509, 24);
            this.TxtValorMinAprov.Name = "TxtValorMinAprov";
            this.TxtValorMinAprov.Size = new System.Drawing.Size(153, 20);
            this.TxtValorMinAprov.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor Min para Visto Aprovação";
            // 
            // TxtValorMaxAprov
            // 
            this.TxtValorMaxAprov.Location = new System.Drawing.Point(668, 25);
            this.TxtValorMaxAprov.Name = "TxtValorMaxAprov";
            this.TxtValorMaxAprov.Size = new System.Drawing.Size(153, 20);
            this.TxtValorMaxAprov.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor Max para Visto Aprovação";
            // 
            // ComboPapel
            // 
            this.ComboPapel.FormattingEnabled = true;
            this.ComboPapel.Location = new System.Drawing.Point(336, 24);
            this.ComboPapel.Name = "ComboPapel";
            this.ComboPapel.Size = new System.Drawing.Size(167, 21);
            this.ComboPapel.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnGravar);
            this.panel1.Controls.Add(this.TxtValorMinAprov);
            this.panel1.Controls.Add(this.ComboPapel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtValorMaxAprov);
            this.panel1.Controls.Add(this.TxtLogin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtSenha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(25, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 104);
            this.panel1.TabIndex = 13;
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(42, 65);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 13;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtValorMinAprov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtValorMaxAprov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboPapel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGravar;
    }
}