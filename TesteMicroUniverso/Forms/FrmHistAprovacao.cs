using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteMicroUniverso.BLL;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso.Forms
{
    public partial class FrmHistAprovacao : Form
    {
        BLL_HistAprovacao BLL_Historico = new BLL_HistAprovacao();
        public FrmHistAprovacao()
        {
            InitializeComponent();
        }

        private async Task CarregaGridAsync()
        {
            DtHistAprovacao.DataSource = await BLL_Historico.ListarHistorico();
        }        

        private async void FrmHistAprovacao_Load(object sender, EventArgs e)
        {
            await CarregaGridAsync();
        }        
    }
}
