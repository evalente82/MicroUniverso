namespace TesteMicroUniverso.Forms
{
    partial class FrmNota
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
            this.dtNota = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkVistoAprovPapel = new System.Windows.Forms.CheckBox();
            this.checkDentroLimiteUsu = new System.Windows.Forms.CheckBox();
            this.checkSemVistoAprov = new System.Windows.Forms.CheckBox();
            this.BtnVistoAprovacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtNota)).BeginInit();
            this.SuspendLayout();
            // 
            // dtNota
            // 
            this.dtNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNota.Location = new System.Drawing.Point(12, 150);
            this.dtNota.Name = "dtNota";
            this.dtNota.Size = new System.Drawing.Size(1214, 266);
            this.dtNota.TabIndex = 0;
            this.dtNota.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtNota_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Período:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(260, 110);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(47, 35);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(97, 20);
            this.dtInicio.TabIndex = 12;
            this.dtInicio.Value = new System.DateTime(2023, 8, 2, 0, 0, 0, 0);
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(241, 35);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(94, 20);
            this.dtFim.TabIndex = 13;
            this.dtFim.Value = new System.DateTime(2023, 8, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Até:";
            // 
            // checkVistoAprovPapel
            // 
            this.checkVistoAprovPapel.AutoSize = true;
            this.checkVistoAprovPapel.Location = new System.Drawing.Point(47, 93);
            this.checkVistoAprovPapel.Name = "checkVistoAprovPapel";
            this.checkVistoAprovPapel.Size = new System.Drawing.Size(160, 17);
            this.checkVistoAprovPapel.TabIndex = 15;
            this.checkVistoAprovPapel.Text = "Visto / Aprovação por Papel";
            this.checkVistoAprovPapel.UseVisualStyleBackColor = true;
            this.checkVistoAprovPapel.CheckedChanged += new System.EventHandler(this.checkVistoAprovPapel_CheckedChanged);
            // 
            // checkDentroLimiteUsu
            // 
            this.checkDentroLimiteUsu.AutoSize = true;
            this.checkDentroLimiteUsu.Location = new System.Drawing.Point(47, 70);
            this.checkDentroLimiteUsu.Name = "checkDentroLimiteUsu";
            this.checkDentroLimiteUsu.Size = new System.Drawing.Size(144, 17);
            this.checkDentroLimiteUsu.TabIndex = 16;
            this.checkDentroLimiteUsu.Text = "Dentro do limite permitido";
            this.checkDentroLimiteUsu.UseVisualStyleBackColor = true;
            this.checkDentroLimiteUsu.CheckedChanged += new System.EventHandler(this.checkDentroLimiteUsu_CheckedChanged);
            // 
            // checkSemVistoAprov
            // 
            this.checkSemVistoAprov.AutoSize = true;
            this.checkSemVistoAprov.Location = new System.Drawing.Point(47, 116);
            this.checkSemVistoAprov.Name = "checkSemVistoAprov";
            this.checkSemVistoAprov.Size = new System.Drawing.Size(136, 17);
            this.checkSemVistoAprov.TabIndex = 17;
            this.checkSemVistoAprov.Text = "Sem Visto / Aprovação";
            this.checkSemVistoAprov.UseVisualStyleBackColor = true;
            this.checkSemVistoAprov.CheckedChanged += new System.EventHandler(this.checkSemVistoAprov_CheckedChanged);
            // 
            // BtnVistoAprovacao
            // 
            this.BtnVistoAprovacao.Location = new System.Drawing.Point(17, 431);
            this.BtnVistoAprovacao.Name = "BtnVistoAprovacao";
            this.BtnVistoAprovacao.Size = new System.Drawing.Size(127, 52);
            this.BtnVistoAprovacao.TabIndex = 18;
            this.BtnVistoAprovacao.Text = "Visto / Aprovação";
            this.BtnVistoAprovacao.UseVisualStyleBackColor = true;
            this.BtnVistoAprovacao.Click += new System.EventHandler(this.BtnVistoAprovacao_Click);
            // 
            // FrmNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 544);
            this.Controls.Add(this.BtnVistoAprovacao);
            this.Controls.Add(this.checkSemVistoAprov);
            this.Controls.Add(this.checkDentroLimiteUsu);
            this.Controls.Add(this.checkVistoAprovPapel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtNota);
            this.Name = "FrmNota";
            this.Text = "Nota";
            this.Load += new System.EventHandler(this.Nota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkVistoAprovPapel;
        private System.Windows.Forms.CheckBox checkDentroLimiteUsu;
        private System.Windows.Forms.CheckBox checkSemVistoAprov;
        private System.Windows.Forms.Button BtnVistoAprovacao;
    }
}