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
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            //this.Visible=false;
            usuario.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            // Realize a validação do usuário aqui antes de exibir o formulário principal
            if (Program.ValidarUsuario(TxtUsuario.Text, TxtSenha.Text))
            {
                // Caso a validação seja bem-sucedida, defina o DialogResult como OK
                DialogResult = DialogResult.OK;
                // O formulário de login será fechado automaticamente
            }
            else
            {
                // Caso a validação falhe, exiba uma mensagem de erro
                MessageBox.Show("Usuário ou senha inválidos. Por favor, tente novamente.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpe os campos de texto
                TxtUsuario.Text = string.Empty;
                TxtSenha.Text = string.Empty;
                // Coloque o foco no campo de usuário para facilitar a correção
                TxtUsuario.Focus();
            }
        }
    }
}
