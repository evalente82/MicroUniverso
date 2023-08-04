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
using TesteMicroUniverso.BLL;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso.Forms
{
    public partial class FrmUsuario : Form
    {
        BLL_Usuario bLL_Usuario = new BLL_Usuario();
        public FrmUsuario()
        {
            InitializeComponent();
            
        }

        private async void Usuario_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            await CarregaGridAsync();
        }

        private async Task CarregaGridAsync()
        {
            DtUsuario.DataSource = await bLL_Usuario.ListUsuarios();
        }

        private async void BtnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtLogin.Text) ||
                string.IsNullOrWhiteSpace(TxtSenha.Text) ||
                string.IsNullOrWhiteSpace(ComboPapel.Text) ||
                string.IsNullOrWhiteSpace(TxtValorMinAprov.Text) ||
                string.IsNullOrWhiteSpace(TxtValorMaxAprov.Text))
            {
                // Exibir uma mensagem de erro informando que todos os campos devem ser preenchidos
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Interrompe o processo de salvamento, já que há campos vazios
            }

            Usuario novoUsuario = new Usuario
            {
                Login = TxtLogin.Text,
                Senha = TxtSenha.Text,
                Papel = ComboPapel.Text,
                ValorMinAprovacao = decimal.Parse(TxtValorMinAprov.Text),
                ValorMaxAprovacao = decimal.Parse(TxtValorMaxAprov.Text)
            };
            await bLL_Usuario.Salvar(novoUsuario);
            LimparCampos();
            await CarregaGridAsync();
        }

        private void LimparCampos()
        {
            IdUsuario.Text = null;
            TxtLogin.Clear();
            TxtSenha.Clear();
            ComboPapel.Items.Clear();
            TxtValorMinAprov.Clear();
            TxtValorMaxAprov.Clear();
        }

        private void TxtValorMinAprov_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números (0-9) e a vírgula (,)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b') // '\b' é o código do backspace (tecla de apagar)
            {
                e.Handled = true; // Cancela o evento KeyPress para que o caractere inválido não seja inserido no TextBox
            }

            // Permite apenas uma vírgula (,) e não permite mais de uma vírgula no texto
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true; // Cancela o evento KeyPress para que a vírgula não seja inserida se já houver outra no TextBox
            }
        }

        private void TxtValorMaxAprov_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números (0-9) e a vírgula (,)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b') // '\b' é o código do backspace (tecla de apagar)
            {
                e.Handled = true; // Cancela o evento KeyPress para que o caractere inválido não seja inserido no TextBox
            }

            // Permite apenas uma vírgula (,) e não permite mais de uma vírgula no texto
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true; // Cancela o evento KeyPress para que a vírgula não seja inserida se já houver outra no TextBox
            }
        }

        private void ConfigurarDataGridView()
        {
            // Adicione a configuração das colunas da DataGridView
            DataGridViewButtonColumn editarColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            };

            DataGridViewButtonColumn apagarColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Apagar",
                Text = "Apagar",
                UseColumnTextForButtonValue = true
            };

            DtUsuario.Columns.Add(editarColumn);
            DtUsuario.Columns.Add(apagarColumn);

            // Adicione um evento para tratar os cliques nos botões
            DtUsuario.CellClick += DataGridView_CellClick;
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se o clique foi em uma célula das colunas de edição ou exclusão
            if (e.RowIndex >= 0 && (DtUsuario.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
            {
                if (DtUsuario.Columns[e.ColumnIndex].HeaderText == "Editar")
                {
                    IdUsuario.Text = DtUsuario.Rows[e.RowIndex].Cells["IdUsuario"].Value.ToString();
                    TxtLogin.Text = DtUsuario.Rows[e.RowIndex].Cells["Login"].Value.ToString();
                    TxtSenha.Text = DtUsuario.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
                    ComboPapel.Text = DtUsuario.Rows[e.RowIndex].Cells["Papel"].Value.ToString();
                    TxtValorMinAprov.Text = DtUsuario.Rows[e.RowIndex].Cells["ValorMinAprovacao"].Value.ToString();
                    TxtValorMaxAprov.Text = DtUsuario.Rows[e.RowIndex].Cells["ValorMaxAprovacao"].Value.ToString();
                    BtnEditar.Enabled = true;
                    BtnGravar.Enabled = false;
                }
                else if (DtUsuario.Columns[e.ColumnIndex].HeaderText == "Apagar")
                {
                    IdUsuario.Text = DtUsuario.Rows[e.RowIndex].Cells["IdUsuario"].Value.ToString();
                    TxtLogin.Text = DtUsuario.Rows[e.RowIndex].Cells["Login"].Value.ToString();
                    TxtSenha.Text = DtUsuario.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
                    ComboPapel.Text = DtUsuario.Rows[e.RowIndex].Cells["Papel"].Value.ToString();
                    TxtValorMinAprov.Text = DtUsuario.Rows[e.RowIndex].Cells["ValorMinAprovacao"].Value.ToString();
                    TxtValorMaxAprov.Text = DtUsuario.Rows[e.RowIndex].Cells["ValorMaxAprovacao"].Value.ToString();

                    IdUsuario.Enabled = false;
                    TxtLogin.Enabled = false;
                    TxtSenha.Enabled = false;
                    ComboPapel.Enabled = false;
                    TxtValorMinAprov.Enabled = false;
                    TxtValorMaxAprov.Enabled = false;

                    BtnEditar.Enabled = false;
                    BtnGravar.Enabled = false;
                    BtnExcluir.Enabled = true;
                }
            }
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtLogin.Text) ||
                string.IsNullOrWhiteSpace(TxtSenha.Text) ||
                string.IsNullOrWhiteSpace(ComboPapel.Text) ||
                string.IsNullOrWhiteSpace(TxtValorMinAprov.Text) ||
                string.IsNullOrWhiteSpace(TxtValorMaxAprov.Text))
            {
                // Exibir uma mensagem de erro informando que todos os campos devem ser preenchidos
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Interrompe o processo de salvamento, já que há campos vazios
            }

            Usuario editarUsuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(IdUsuario.Text),
                Login = TxtLogin.Text,
                Senha = TxtSenha.Text,
                Papel = ComboPapel.Text,
                ValorMinAprovacao = Convert.ToDecimal(TxtValorMinAprov.Text),
                ValorMaxAprovacao = Convert.ToDecimal(TxtValorMaxAprov.Text)
            };
            await bLL_Usuario.Editar(editarUsuario);
            LimparCampos();
            await CarregaGridAsync();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ExibirMessageBoxComSimENao();
        }

        private async void ExibirMessageBoxComSimENao()
        {
            // Exibe a MessageBox com os botões "Sim" e "Não" e obtém o resultado do clique
            DialogResult resultado = MessageBox.Show("Deseja Deletar este registro ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica o resultado do clique
            if (resultado == DialogResult.Yes)
            {
                await bLL_Usuario.Apagar(Convert.ToInt32(IdUsuario.Text));
                LimparCampos();
                await CarregaGridAsync();
                BtnEditar.Enabled = false;
                BtnGravar.Enabled = true;
                BtnExcluir.Enabled = false;

                IdUsuario.Enabled = true;
                TxtLogin.Enabled = true;
                TxtSenha.Enabled = true;
                ComboPapel.Enabled = true;
                TxtValorMinAprov.Enabled = true;
                TxtValorMaxAprov.Enabled = true;
            }
            else if (resultado == DialogResult.No)
            {
                
            }
        }
    }
}
