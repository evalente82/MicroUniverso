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
using TesteMicroUniverso.BLL;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso.Forms
{
    public partial class FrmNota : Form
    {
        BLL_Nota BLL_Nota = new BLL_Nota();

        public FrmNota()
        {
            InitializeComponent();
        }              

        private async void Nota_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();

            await CarregaGridAsync();            
        }

        private async Task CarregaGridAsync()
        {
            dtNota.DataSource = await BLL_Nota.ListarNotas();
        }

        private void ConfigurarDataGridView()
        {            
            DataGridViewCheckBoxColumn vistoAprovacao = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Visto / Aprovação",
                Name = "checkBoxColumn",
                ReadOnly = false
            };
            dtNota.Columns.Add(vistoAprovacao);
        }

        private async void BtnVistoAprovacao_Click(object sender, EventArgs e)
        {
            List<int> idNotas = new List<int>();
            
            foreach (DataGridViewRow row in dtNota.Rows)
            {                
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    int idNota = Convert.ToInt32(row.Cells["IdNota"].Value);
                    idNotas.Add(idNota);
                }
            }
            await BLL_Nota.VistoAprovacao(idNotas);
            await CarregaGridAsync();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dtInicio.Value;
            DateTime dataFim = dtFim.Value;

            if (checkDentroLimiteUsu.Checked)
            {
                dtNota.DataSource = null;
                dtNota.DataSource = BLL_Nota.ListarNotasDentroLimiteUsu(dataInicio, dataFim);
            }
            else if (checkVistoAprovPapel.Checked)
            {
                dtNota.DataSource = null;
                dtNota.DataSource = BLL_Nota.ListarNotasPapel(dataInicio, dataFim);
            }
            else if (checkSemVistoAprov.Checked)
            {
                dtNota.DataSource = null;
                dtNota.DataSource = BLL_Nota.ListarSemVistoAprov(dataInicio, dataFim);
            }
        }

        private void checkDentroLimiteUsu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDentroLimiteUsu.Checked)
            {
                checkVistoAprovPapel.Checked = false;
                checkSemVistoAprov.Checked = false;
            }
        }

        private void checkVistoAprovPapel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVistoAprovPapel.Checked)
            {
                checkDentroLimiteUsu.Checked = false;
                checkSemVistoAprov.Checked = false;
            }
        }

        private void checkSemVistoAprov_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSemVistoAprov.Checked)
            {
                checkDentroLimiteUsu.Checked = false;
                checkVistoAprovPapel.Checked = false;
            }
        }

        private void dtNota_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /// Verifica se a célula atual não é uma célula de cabeçalho
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtém a coluna atual
                DataGridViewColumn column = dtNota.Columns[e.ColumnIndex];

                // Verifica se a coluna atual é a coluna Status
                if (column.Name == "Status")
                {
                    // Obtém o valor da célula atual
                    object cellValue = e.Value;

                    // Verifica se o valor é um booleano (true ou false)
                    if (cellValue is bool)
                    {
                        // Converte o valor para booleano
                        bool statusValue = (bool)cellValue;

                        // Define o valor formatado para exibir na célula
                        e.Value = statusValue ? "Aprovado" : "Pendente";

                        // Define o tipo de célula como texto para garantir que o valor formatado seja exibido corretamente
                        e.FormattingApplied = true;
                    }
                }
            }
        }
        
    }
}
