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
            Usuario usuario = new Usuario();
            usuario.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            nota.Show();
        }

        private void históricoAprovaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistAprovacao histAprovacao = new HistAprovacao();
            histAprovacao.Show();
        }

        private void canfiguraçãoFaixasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigFaixaPreco faixaPreco = new ConfigFaixaPreco();
            faixaPreco.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
