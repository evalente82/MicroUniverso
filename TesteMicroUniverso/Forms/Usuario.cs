using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso.Forms
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
            
        }

        private async void Usuario_Load(object sender, EventArgs e)
        {
            var dbContext = new AppDbContext();
            var results = await dbContext.Usuarios.ToListAsync();

            DtUsuario.DataSource = results;

        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {

        }
    }
}
