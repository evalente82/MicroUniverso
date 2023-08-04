namespace TesteMicroUniverso.Forms
{
    partial class FrmHistAprovacao
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
            this.DtHistAprovacao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtHistAprovacao)).BeginInit();
            this.SuspendLayout();
            // 
            // DtHistAprovacao
            // 
            this.DtHistAprovacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtHistAprovacao.Location = new System.Drawing.Point(12, 118);
            this.DtHistAprovacao.Name = "DtHistAprovacao";
            this.DtHistAprovacao.Size = new System.Drawing.Size(776, 271);
            this.DtHistAprovacao.TabIndex = 0;
            // 
            // FrmHistAprovacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtHistAprovacao);
            this.Name = "FrmHistAprovacao";
            this.Text = "HistAprovacao";
            this.Load += new System.EventHandler(this.FrmHistAprovacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtHistAprovacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtHistAprovacao;
    }
}