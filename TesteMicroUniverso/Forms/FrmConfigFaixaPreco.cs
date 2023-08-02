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
    public partial class FrmConfigFaixaPreco : Form
    {
        public FrmConfigFaixaPreco()
        {
            InitializeComponent();
        }

        private async void ConfigFaixaPreco_Load(object sender, EventArgs e)
        {
            var dbContext = new AppDbContext();

            var results = await dbContext.ConfigFaixaPreco.ToListAsync();


            dtConfigFaixa.DataSource = results;
        }
    }
}
