using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso.Forms
{
    public partial class Principal : Form        
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNota frmNota = new FrmNota();
            frmNota.Show();
        }

        private void históricoAprovaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistAprovacao frmHistAprovacao = new FrmHistAprovacao();
            frmHistAprovacao.Show();
        }

        private void canfiguraçãoFaixasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfigFaixaPreco frmFaixaPreco = new FrmConfigFaixaPreco();
            frmFaixaPreco.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
