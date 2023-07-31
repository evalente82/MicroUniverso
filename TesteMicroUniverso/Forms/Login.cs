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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            //this.Visible=false;
            usuario.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
