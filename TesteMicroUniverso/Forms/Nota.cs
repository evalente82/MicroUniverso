using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso.Forms
{
    public partial class Nota : Form
    {
        public Nota()
        {
            InitializeComponent();
        }
              

        private async void Nota_Load(object sender, EventArgs e)
        {
            var dbContext = new AppDbContext();

            var results = await dbContext.Nota.ToListAsync();
           
            dtNota.DataSource = results;
        }
    }
}
